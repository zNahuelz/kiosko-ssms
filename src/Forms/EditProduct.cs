using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using kiosko_ssms.Services;
using kiosko_ssms.Utils;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class EditProduct : Krypton.Toolkit.KryptonForm
    {
        private double TAX_PERCENTAGE = 0.18;
        private readonly AppDbContext DB_CONTEXT = new Data.AppDbContext();

        private int selectedProductId = 0;
        public EditProduct()
        {
            InitializeComponent();
            txtKeyword.CausesValidation = false;
            btnSearch.CausesValidation = false;
            btnReset.CausesValidation = false;
            btnRandomBarcode.CausesValidation = false;
            cbSupplier.CausesValidation = false;
            cbPresentation.CausesValidation = false;
            LoadTax();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            FillSuppliersCombo();
            FillPresentationsCombo();
            HandleInfoFields(false);
            HandleSearchFields(true);
            txtKeyword.Focus();
        }

        private void FillSuppliersCombo()
        {
            try
            {
                SupplierService _supplierService = new SupplierService(DB_CONTEXT);
                cbSupplier.DataSource = _supplierService.GetAllSuppliers(false);
                cbSupplier.DisplayMember = "Name";

            }
            catch
            {
                cbSupplier.Enabled = false;
                btnReset.Enabled = false;
                btnUpdate.Enabled = false;
                btnRandomBarcode.Enabled = false;
                MessageBox.Show(Constants.Messages.Error.SUPPLIERS_LOAD_FAILED_CREATE_PRODUCT_DISABLED, Constants.Messages.Error.ERROR_TAG, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillPresentationsCombo()
        {
            try
            {
                PresentationService _presentationService = new PresentationService(DB_CONTEXT);
                cbPresentation.DataSource = _presentationService.GetAllPresentations(false);
            }
            catch
            {
                cbPresentation.Enabled = false;
                btnReset.Enabled = false;
                btnUpdate.Enabled = false;
                btnRandomBarcode.Enabled = false;
                MessageBox.Show(Constants.Messages.Error.PRESENTATION_LOAD_FAILED_CREATE_PRODUCT_DISABLED, Constants.Messages.Error.ERROR_TAG, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleInfoFields(bool isEnabled)
        {
            txtBarcode.Enabled = isEnabled;
            txtName.Enabled = isEnabled;
            txtDescription.Enabled = isEnabled;
            txtProfit.Enabled = isEnabled;
            nudBuyPrice.Enabled = isEnabled;
            nudSellPrice.Enabled = isEnabled;
            nudStock.Enabled = isEnabled;
            nudStockMin.Enabled = isEnabled;
            cbSupplier.Enabled = isEnabled;
            cbPresentation.Enabled = isEnabled;
            btnRandomBarcode.Enabled = isEnabled;
            btnUpdate.Enabled = isEnabled;
            btnReset.Enabled = isEnabled;
            chkIsDeleted.Enabled = isEnabled;
            chkIsVisible.Enabled = isEnabled;
        }

        private void HandleSearchFields(bool isEnabled)
        {
            txtKeyword.Enabled = isEnabled;
            btnSearch.Enabled = isEnabled;
        }

        private void ClearFields()
        {
            txtBarcode.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            txtProfit.Text = "---";
            nudBuyPrice.Value = 1;
            nudSellPrice.Value = 1;
            nudStock.Value = 1;
            nudStockMin.Value = 1;
            if (cbSupplier.Items.Count > 0)
            {
                cbSupplier.SelectedIndex = 0;
            }
            if (cbPresentation.Items.Count > 0)
            {
                cbPresentation.SelectedIndex = 0;
            }
            chkIsVisible.Checked = false;
            chkIsDeleted.Checked = false;
        }

        private void txtKeyword_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtKeyword.Text = Clipboard.GetText().Trim().ToUpper();
                btnSearch.PerformClick();
            }
            catch
            {
                txtKeyword.Text = "";
            }
        }

        private void txtKeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSearch.PerformClick();
            }
        }

        private bool ValidateBarcode(TextBox field)
        {
            string barcode = field.Text.Trim();

            if (string.IsNullOrWhiteSpace(barcode))
            {
                errorProvider.SetError(field, "Debe ingresar un código de barras.");
                return false;
            }
            if (!Regex.IsMatch(barcode, @"^[A-Za-z0-9]{8,30}$"))
            {
                errorProvider.SetError(field, "El código de barras debe tener entre 8 y 30 caracteres alfanuméricos.");
                return false;
            }

            errorProvider.SetError(field, "");
            return true;
        }

        private bool ValidateBarcode(Krypton.Toolkit.KryptonTextBox field)
        {
            string barcode = field.Text.Trim();

            if (string.IsNullOrWhiteSpace(barcode))
            {
                errorProvider.SetError(field, "Debe ingresar un código de barras.");
                return false;
            }
            if (!Regex.IsMatch(barcode, @"^[A-Za-z0-9]{8,30}$"))
            {
                errorProvider.SetError(field, "El código de barras debe tener entre 8 y 30 caracteres alfanuméricos.");
                return false;
            }

            errorProvider.SetError(field, "");
            return true;
        }


        private bool ValidateSearch()
        {
            if (!ValidateBarcode(txtKeyword))
            {
                txtKeyword.Focus();
                return false;
            }
            return true;
        }

        private void SearchProduct(string barcode)
        {
            ProductService productService = new ProductService(DB_CONTEXT);
            var product = productService.GetProductsByBarcode(barcode);
            if (product.Count <= 0)
            {
                MessageBox.Show("No se encontró ningún producto con el código de barras ingresado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKeyword.Focus();
                ClearFields();
                return;
            }
            else
            {
                FillFields(product[0]);
            }
        }

        private void FillFields(Product product)
        {
            selectedProductId = product.Id;
            txtBarcode.Text = product.Barcode;
            txtName.Text = product.Name;
            txtDescription.Text = product.Description;
            nudBuyPrice.Value = product.BuyPrice;
            nudSellPrice.Value = product.SellPrice;
            txtProfit.Text = Math.Round(product.Profit, 2).ToString();
            nudStock.Value = product.Stock;
            nudStockMin.Value = product.StockMin;
            cbSupplier.SelectedItem = product.Supplier;
            cbPresentation.SelectedItem = product.Presentation;
            chkIsDeleted.Checked = product.IsDeleted;
            chkIsVisible.Checked = product.IsVisible;
            HandleInfoFields(true);
            HandleSearchFields(false);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (ValidateSearch())
            {
                SearchProduct(txtKeyword.Text.Trim());
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
            HandleInfoFields(false);
            HandleSearchFields(true);
            selectedProductId = 0;
            txtKeyword.Clear();
            txtKeyword.Focus();
            lblTaxValue.Text = "IMPUESTO: ---";
        }

        private string GenerateRandomBarcode()
        {
            bool valid = false;
            string barcode = "";
            while (!valid)
            {
                barcode = BarcodeFactory();
                var products = new ProductService(DB_CONTEXT).GetProductsByBarcode(barcode);
                if (products.Count <= 0)
                {
                    valid = true;
                }
            }
            return barcode;
        }

        private string BarcodeFactory()
        {
            Random random = new Random();
            int value = random.Next(1, 100000);
            string barcode = value.ToString().PadLeft(13, '0');
            return barcode;
        }

        private void btnRandomBarcode_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ADVERTENCIA: Esta funcionalidad genera un código de barras aleatorio para el producto. Solo cambie el código de barras de ser necesario. ¿Desea continuar?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string randomBarcode = GenerateRandomBarcode();
                txtBarcode.Text = randomBarcode;
                txtKeyword.Text = randomBarcode;
            }
        }

        private decimal CalculateProfit(decimal buyPrice, decimal sellPriceWithTax)
        {
            if (buyPrice <= 0 || sellPriceWithTax <= 0)
                return 0;

            decimal sellPriceWithoutTax = sellPriceWithTax / (1 + (decimal)TAX_PERCENTAGE);
            decimal profit = Math.Round((sellPriceWithoutTax - buyPrice), 2);

            return profit > 0 ? profit : 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateEditFields())
            {
                Product product = new Product
                {
                    Id = selectedProductId,
                    Barcode = txtBarcode.Text,
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    BuyPrice = nudBuyPrice.Value,
                    SellPrice = nudSellPrice.Value,
                    Profit = CalculateProfit(nudBuyPrice.Value, nudSellPrice.Value),
                    Stock = (int)nudStock.Value,
                    StockMin = (int)nudStockMin.Value,
                    SupplierId = ((Supplier)cbSupplier.SelectedItem).Id,
                    PresentationId = ((Presentation)cbPresentation.SelectedItem).Id,
                    IsDeleted = chkIsDeleted.Checked ? true : false,
                    IsVisible = chkIsVisible.Checked ? true : false,
                };

                try
                {
                    ProductService productService = new ProductService(DB_CONTEXT);
                    var updatedProduct = productService.UpdateProduct(product);
                    MessageBox.Show($"Producto: {updatedProduct.Name} actualizado exitosamente. ID: {updatedProduct.Id} y Código de Barras: {updatedProduct.Barcode}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    HandleInfoFields(false);
                    HandleSearchFields(true);
                    selectedProductId = 0;
                    txtKeyword.Text = "";
                    txtKeyword.Focus();
                    lblTaxValue.Text = "IMPUESTO: ---";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el producto. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private bool ValidateName()
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                errorProvider.SetError(txtName, "Debe ingresar un nombre.");
                return false;
            }
            if (name.Length < 5 || name.Length > 100)
            {
                errorProvider.SetError(txtName, "El nombre debe tener entre 5 y 100 caracteres.");
                return false;
            }
            if (!Regex.IsMatch(name, @"^.*\S.*$"))
            {
                errorProvider.SetError(txtName, "El nombre no puede ser solo espacios en blanco.");
                return false;
            }
            if (!Regex.IsMatch(name, @"^\S.*$"))
            {
                errorProvider.SetError(txtName, "El nombre no debe comenzar con espacios.");
                return false;
            }

            errorProvider.SetError(txtName, "");
            return true;
        }

        private bool ValidateDescription()
        {
            string description = txtDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(description))
            {
                errorProvider.SetError(txtDescription, "Debe ingresar una descripción.");
                return false;
            }
            if (description.Length < 5 || description.Length > 150)
            {
                errorProvider.SetError(txtDescription, "La descripción debe tener entre 5 y 150 caracteres.");
                return false;
            }
            if (!Regex.IsMatch(description, @"^.*\S.*$"))
            {
                errorProvider.SetError(txtDescription, "La descripción no puede ser solo espacios en blanco.");
                return false;
            }
            if (!Regex.IsMatch(description, @"^\S.*$"))
            {
                errorProvider.SetError(txtDescription, "La descripción no debe comenzar con espacios.");
                return false;
            }

            errorProvider.SetError(txtDescription, "");
            return true;
        }

        private bool ValidateBuyPrice()
        {
            decimal buyPrice = nudBuyPrice.Value;

            if (buyPrice <= 0)
            {
                errorProvider.SetError(nudBuyPrice, "El precio de compra debe ser positivo.");
                return false;
            }
            if (!Regex.IsMatch(buyPrice.ToString(), @"^\d+(\.\d{1,2})?$"))
            {
                errorProvider.SetError(nudBuyPrice, "Máximo dos decimales permitidos.");
                return false;
            }

            errorProvider.SetError(nudBuyPrice, "");
            return true;
        }

        private bool ValidateSellPrice()
        {
            decimal sellPrice = nudSellPrice.Value;
            decimal buyPrice = nudBuyPrice.Value;

            if (sellPrice <= 0)
            {
                errorProvider.SetError(nudSellPrice, "El precio de venta debe ser positivo.");
                return false;
            }
            if (!Regex.IsMatch(sellPrice.ToString(), @"^\d+(\.\d{1,2})?$"))
            {
                errorProvider.SetError(nudSellPrice, "Máximo dos decimales permitidos.");
                return false;
            }
            if (sellPrice < buyPrice)
            {
                errorProvider.SetError(nudSellPrice, "El precio de venta debe ser igual o superior al de compra.");
                return false;
            }

            errorProvider.SetError(nudSellPrice, "");
            return true;
        }

        private bool ValidateStock()
        {
            decimal stock = nudStock.Value;

            if (stock <= 0)
            {
                errorProvider.SetError(nudStock, "El valor de stock debe ser superior a 0.");
                return false;
            }

            errorProvider.SetError(nudStock, "");
            return true;
        }

        private bool ValidateStockMin()
        {
            decimal stockMin = nudStockMin.Value;

            if (stockMin < 0)
            {
                errorProvider.SetError(nudStockMin, "El stock mínimo no puede ser negativo.");
                return false;
            }

            errorProvider.SetError(nudStockMin, "");
            return true;
        }

        private bool ValidateSupplier()
        {
            if (cbSupplier.SelectedItem == null)
            {
                errorProvider.SetError(cbSupplier, "Debe seleccionar un proveedor.");
                return false;
            }
            if (cbSupplier.SelectedIndex < 0)
            {
                errorProvider.SetError(cbSupplier, "Debe seleccionar un proveedor.");
                return false;
            }
            errorProvider.SetError(cbSupplier, "");
            return true;
        }

        private bool ValidatePresentation()
        {
            if (cbPresentation.SelectedItem == null)
            {
                errorProvider.SetError(cbPresentation, "Debe seleccionar una presentación.");
                return false;
            }
            if (cbPresentation.SelectedIndex < 0)
            {
                errorProvider.SetError(cbPresentation, "Debe seleccionar una presentación.");
                return false;
            }
            errorProvider.SetError(cbPresentation, "");
            return true;
        }

        private bool ValidateExistingBarcode(string barcode)
        {
            var products = new ProductService(DB_CONTEXT).GetProductsByBarcode(barcode);
            if (products.Count > 0)
            {
                if (products[0].Id == selectedProductId)
                {
                    errorProvider.SetError(txtBarcode, "");
                    return true;
                }
                errorProvider.SetError(txtBarcode, "El código de barras ya existe en otro producto.");
                return false;
            }
            errorProvider.SetError(txtBarcode, "");
            return true;
        }

        private bool ValidateEditFields()
        {
            bool isValid = true;

            if (!ValidateBarcode(txtBarcode)) isValid = false;
            if (ValidateBarcode(txtBarcode))
            {
                if (!ValidateExistingBarcode(txtBarcode.Text.Trim())) isValid = false;
            }
            if (!ValidateName()) isValid = false;
            if (!ValidateDescription()) isValid = false;
            if (!ValidateBuyPrice()) isValid = false;
            if (!ValidateSellPrice()) isValid = false;
            if (!ValidateStock()) isValid = false;
            if (!ValidateStockMin()) isValid = false;
            if (!ValidateSupplier()) isValid = false;
            if (!ValidatePresentation()) isValid = false;

            return isValid;
        }

        private void CalculateProfit()
        {
            if (ValidateBuyPrice() && ValidateSellPrice())
            {
                decimal buyPrice = nudBuyPrice.Value;
                decimal sellPriceWithTax = nudSellPrice.Value;
                decimal TAX_PERCENTAGE = 0.18m;

                if (buyPrice > 0)
                {
                    decimal sellPriceWithoutTax = sellPriceWithTax / (1 + TAX_PERCENTAGE);
                    decimal taxValue = sellPriceWithTax - sellPriceWithoutTax;
                    decimal profit = sellPriceWithoutTax - buyPrice;

                    txtProfit.Text = $"{Math.Round(profit, 2)}";
                    lblTaxValue.Text = $"IMPUESTO ({Properties.Settings.Default.taxName}): {Properties.Settings.Default.currencyShortName} {taxValue:F2}";
                }
                else
                {
                    txtProfit.Text = "---";
                    lblTaxValue.Text = $"IMPUESTO ({Properties.Settings.Default.taxName}): ---";
                }
            }
            else
            {
                txtProfit.Text = "---";
                lblTaxValue.Text = $"IMPUESTO ({Properties.Settings.Default.taxName}): ---";
            }
        }

        private void LoadTax()
        {
            try
            {
                TAX_PERCENTAGE = Properties.Settings.Default.taxValue;
                lblTaxPercentage.Text = $"IMPUESTO (%) {(TAX_PERCENTAGE * 100).ToString()}%";
            }
            catch
            {
                TAX_PERCENTAGE = 0.18;
            }
        }

        private void nudBuyPrice_ValueChanged(object sender, EventArgs e)
        {
            CalculateProfit();
        }

        private void nudSellPrice_ValueChanged(object sender, EventArgs e)
        {
            CalculateProfit();
        }
    }
}
