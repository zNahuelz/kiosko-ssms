using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using kiosko_ssms.Data.Helpers;
using kiosko_ssms.Services;
using kiosko_ssms.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class NewSale : Krypton.Toolkit.KryptonForm
    {
        private List<CartItem> cart = new List<CartItem>();
        private Customer customer = null;
        private double subtotal = 0;
        private double tax = 0;
        private double total = 0;
        private List<PaymentType> paymentTypes = new List<PaymentType>();
        private List<VoucherType> voucherTypes = new List<VoucherType>();

        public NewSale()
        {
            InitializeComponent();
            btnSave.Enabled = false;
            btnClearCart.Enabled = false;
            btnCancel.Enabled = false;
            btnUnlockCustomerSearch.Enabled = false;
            HandleProductInfoFields(false);
            HandleCustomerInfoFields(true);
        }

        private void NewSale_Load(object sender, EventArgs e)
        {
            FillPaymentTypes();
            FillVoucherTypes();
        }

        private void HandleCustomerInfoFields(bool isEnabled)
        {
            txtDni.Enabled = isEnabled;
            btnSearchCustomer.Enabled = isEnabled;
        }

        private void HandleProductInfoFields(bool isEnabled)
        {
            txtBarcode.Enabled = isEnabled;
            btnAddProduct.Enabled = isEnabled;
            cbPaymentType.Enabled = isEnabled;
            cbVoucherType.Enabled = isEnabled;
        }

        private void HandleCustomerInfo(Customer customer)
        {
            if (customer != null)
            {
                lblDni.Text = $"DNI: {customer.Dni}";
                lblNames.Text = $"Nombres: {(customer.Names.Length > 12 ? customer.Names.Substring(0, 12) : customer.Names)}.";
                lblSurnames.Text = $"Apellidos: {(customer.Surnames.Length > 12 ? customer.Names.Substring(0, 12) : customer.Surnames)}.";
            }
            else
            {
                lblDni.Text = "DNI: ---";
                lblNames.Text = "Nombres: ---";
                lblSurnames.Text = "Apellidos: ---";
            }
        }

        private void HandleSaleButtons()
        {
            if (cart.Count >= 1)
            {
                btnClearCart.Enabled = true;
                btnSave.Enabled = true;
            }
            else
            {
                btnClearCart.Enabled = false;
                btnSave.Enabled = false;
            }
        }

        private bool ValidateDni()
        {
            string dni = txtDni.Text.Trim();
            if (string.IsNullOrWhiteSpace(dni))
            {
                errorProvider.SetError(txtDni, "Debe ingresar un DNI.");
                return false;
            }
            if (!Regex.IsMatch(dni, @"^.*\S.*$"))
            {
                errorProvider.SetError(txtDni, "El DNI no puede ser solo espacios en blanco.");
                return false;
            }
            if (!Regex.IsMatch(dni, @"^\S.*$"))
            {
                errorProvider.SetError(txtDni, "El DNI no debe comenzar con espacios en blanco.");
                return false;
            }
            if (!Regex.IsMatch(dni, @"^(0|[0-9]{7,15})$"))
            {
                errorProvider.SetError(txtDni, "El DNI solo debe contener números.");
                return false;
            }
            errorProvider.SetError(txtDni, "");
            return true;
        }

        private bool ValidateBarcode()
        {
            string barcode = txtBarcode.Text.Trim();
            if (string.IsNullOrWhiteSpace(barcode))
            {
                errorProvider.SetError(txtBarcode, "Debe ingresar un código de barras.");
                return false;
            }
            if (!Regex.IsMatch(barcode, @"^[A-Za-z0-9]{8,30}$"))
            {
                errorProvider.SetError(txtBarcode, "El código de barras debe tener entre 8 y 30 caracteres alfanuméricos.");
                return false;
            }
            errorProvider.SetError(txtBarcode, "");
            return true;
        }

        private void FillPaymentTypes()
        {
            using (var context = new AppDbContext())
            {
                var _paymentTypes = new PaymentTypeService(context).GetAllPaymentTypes(false);
                if (_paymentTypes.Any())
                {
                    paymentTypes = _paymentTypes;
                    cbPaymentType.DataSource = paymentTypes;
                    cbPaymentType.DisplayMember = "Name";
                }
                else
                {
                    HandleCustomerInfoFields(false);
                    HandleProductInfoFields(false);
                    HandleSaleButtons();
                    DialogResult dialog = MessageBox.Show(Constants.Messages.Error.PAYMENT_TYPES_NOT_LOADED, Constants.Messages.Error.ERROR_TAG, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dialog == DialogResult.OK) { Close(); }
                }
            }
        }

        private void FillVoucherTypes()
        {
            using (var context = new AppDbContext())
            {
                var _voucherTypes = new VoucherService(context).GetAllVoucherTypes(false);
                if (_voucherTypes.Any())
                {
                    voucherTypes = _voucherTypes;
                    cbVoucherType.DataSource = voucherTypes;
                    cbVoucherType.DisplayMember = "Name";
                }
                else
                {
                    HandleCustomerInfoFields(false);
                    HandleProductInfoFields(false);
                    HandleSaleButtons();
                    DialogResult dialog = MessageBox.Show(Constants.Messages.Error.VOUCHER_TYPES_NOT_LOADED, Constants.Messages.Error.ERROR_TAG, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dialog == DialogResult.OK) { Close(); }
                }
            }
        }

        private void SearchCustomerByDni(string dni)
        {
            using (var context = new AppDbContext())
            {
                var foundCustomer = new CustomerService(context).GetCustomersByDni(dni, false);
                if (foundCustomer.Count == 1)
                {
                    customer = foundCustomer[0];
                    HandleCustomerInfo(customer);
                    HandleProductInfoFields(true);
                    HandleCustomerInfoFields(false);
                    btnCancel.Enabled = true;
                    btnUnlockCustomerSearch.Enabled = true;
                    txtBarcode.Focus();
                }
                else
                {
                    MessageBox.Show(Constants.Messages.Error.CUSTOMER_NOT_FOUND_BY_DNI_SALES_MODULE, Constants.Messages.Error.ERROR_TAG, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void AddProductToCart(string barcode)
        {
            using (var context = new AppDbContext())
            {
                var products = new ProductService(context).GetProductsByBarcode(barcode);
                if (products.Count >= 1)
                {
                    var existingItem = cart.FirstOrDefault(i => i.Product.Barcode == barcode);
                    if (existingItem != null)
                    {
                        existingItem.Amount += 1;
                        existingItem.Tax = (double)CalculateTaxValue(existingItem.Product.SellPrice, Convert.ToDecimal(Properties.Settings.Default.taxValue), existingItem.Amount);
                    }
                    else
                    {
                        var product = products[0];
                        cart.Add(new CartItem
                        {
                            Product = product,
                            Amount = 1,
                            Cost = product.SellPrice,
                            Tax = (double)CalculateTaxValue(product.SellPrice, Convert.ToDecimal(Properties.Settings.Default.taxValue))
                        });
                    }
                    FillTable();
                    DoMath();
                }
                else
                {
                    MessageBox.Show(Constants.Messages.Error.PRODUCT_NOT_FOUND_BY_BARCODE, Constants.Messages.Error.ERROR_TAG, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private decimal CalculateTaxValue(decimal sellPriceWithTax, decimal taxPercentage, int amount = 1)
        {
            if (sellPriceWithTax <= 0)
                return 0;
            decimal basePrice = sellPriceWithTax / (1 + taxPercentage);
            decimal taxValue = sellPriceWithTax - basePrice;
            return taxValue * amount;
        }

        private void DoMath()
        {
            subtotal = 0;
            total = 0;
            foreach (CartItem item in cart)
            {
                subtotal += (double)(item.Amount * item.Cost);
                total += (double)(item.Amount * item.Cost);
            }
            lblSubtotal.Text = $"SUBTOTAL: {subtotal:F2}";
            lblTotal.Text = $"TOTAL: {total:F2}";
            HandleSaleButtons();
        }

        private void FillTable()
        {
            dgvCart.DataSource = null;
            dgvCart.DataSource = cart;
            ConfigureTable(dgvCart);
        }

        private void ConfigureTable(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.Columns.Clear();
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "PRODUCTO", DataPropertyName = "ProductName" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "PRESENTACIÓN", DataPropertyName = "PresentationName" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "CANTIDAD", DataPropertyName = "Amount", DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight } });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "COSTO", DataPropertyName = "Cost", DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight } });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "SUBTOTAL", DataPropertyName = "Subtotal", DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight } });
        }

        private void ClearCart()
        {
            cart.Clear();
            txtBarcode.Clear();
            ConfigureTable(dgvCart);
            subtotal = 0;
            total = 0;
            tax = 0;
            lblSubtotal.Text = "SUBTOTAL: ---";
            lblTax.Text = "IGV: ---";
            lblTotal.Text = "TOTAL: ---";
            cbVoucherType.SelectedIndex = 0;
            cbPaymentType.SelectedIndex = 0;
            HandleSaleButtons();
        }

        private void RemoveElementFromCart(CartItem item, bool removeAll)
        {
            if (removeAll)
            {
                cart.Remove(item);
            }
            else
            {
                foreach (CartItem i in cart.ToList())
                {
                    if (i.Equals(item))
                    {
                        if (i.Amount > 1)
                        {
                            i.Amount -= 1;
                        }
                        else
                        {
                            cart.Remove(i);
                        }
                        break;
                    }
                }
            }
            FillTable();
            DoMath();
        }

        private void ResetSale()
        {
            cbPaymentType.SelectedIndex = 0;
            cbVoucherType.SelectedIndex = 0;
            ClearCart();
            customer = null;
            btnUnlockCustomerSearch.PerformClick();
            DoMath();
        }

        private void SaveSale(double change)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var createdVoucher = new VoucherService(context).CreateVoucher(cart, customer, cbVoucherType.SelectedItem as VoucherType, cbPaymentType.SelectedItem as PaymentType, change);
                    MessageBox.Show(Constants.Messages.Success.SALE_SAVED(createdVoucher.SaleSerial, createdVoucher.Id, customer), Constants.Messages.Success.SUCCESS_TAG, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancel.PerformClick();
                    btnUnlockCustomerSearch.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Constants.Messages.Error.SALE_SAVE_FAILED} \nINFO: {ex.Message}", Constants.Messages.Error.ERROR_TAG, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowSaleDialog()
        {
            using (var dialog = new SaleDialog(total))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    double change = dialog.ChangeValue;
                    SaveSale(change);
                }
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            if (ValidateDni())
            {
                SearchCustomerByDni(txtDni.Text?.Trim() == "0" ? "00000000" : txtDni.Text.Trim());
            }
        }

        private void btnUnlockCustomerSearch_Click(object sender, EventArgs e)
        {
            txtDni.Clear();
            txtBarcode.Clear();
            customer = null;
            HandleCustomerInfo(customer);
            HandleCustomerInfoFields(true);
            HandleProductInfoFields(false);
            btnCancel.Enabled = false;
            btnUnlockCustomerSearch.Enabled = false;
            cbPaymentType.Enabled = false;
            cbVoucherType.Enabled = false;
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidateDni())
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    btnSearchCustomer.PerformClick();
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (ValidateBarcode())
            {
                AddProductToCart(txtBarcode.Text.Trim());
            }
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidateBarcode())
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    btnAddProduct.PerformClick();
                }
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            ClearCart();
        }

        private void btnRemoveElement_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                var cartItem = (CartItem)dgvCart.SelectedRows[0].DataBoundItem;
                RemoveElementFromCart(cartItem, true);
            }
        }

        private void btnSubtractElement_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                var cartItem = (CartItem)dgvCart.SelectedRows[0].DataBoundItem;
                RemoveElementFromCart(cartItem, false);
            }
        }

        private void dgvCart_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvCart.ClearSelection();
                dgvCart.Rows[e.RowIndex].Selected = true;
                dgvCart.CurrentCell = dgvCart.Rows[e.RowIndex].Cells[e.ColumnIndex];
                contextMenu.Show(Cursor.Position);
            }
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCart.CurrentRow.Selected = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetSale();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbPaymentType.SelectedItem is PaymentType paymentType)
            {
                if (paymentType.Name == "EFECTIVO")
                {
                    ShowSaleDialog();
                }
                else
                {
                    SaveSale(0);
                }
            }
        }

    }
}
