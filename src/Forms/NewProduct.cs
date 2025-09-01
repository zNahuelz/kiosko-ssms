using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using kiosko_ssms.Services;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class NewProduct : Krypton.Toolkit.KryptonForm
    {
        private readonly AppDbContext DB_CONTEXT = new Data.AppDbContext();

        public NewProduct()
        {
            InitializeComponent();
            btnClear.CausesValidation = false;
            btnRandomBarcode.CausesValidation = false;
            cbSupplier.CausesValidation = false;
            cbPresentation.CausesValidation = false;
        }

        private void NewProduct_Load(object sender, EventArgs e)
        {
            FillSuppliersCombo();
            FillPresentationsCombo();
        }

        private void btnRandomBarcode_Click(object sender, EventArgs e)
        {
            txtBarcode.Text = GenerateRandomBarcode();
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
                btnClear.Enabled = false;
                btnSave.Enabled = false;
                btnRandomBarcode.Enabled = false;
                MessageBox.Show("Imposible cargar el listado de proveedores. La creación de productos se encuentra deshabilitada. Debe tener proveedores registrados previamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillPresentationsCombo()
        {
            try
            {
                PresentationService _presentationService = new PresentationService(DB_CONTEXT);
                cbPresentation.DataSource = _presentationService.getAllPresentations(false);
            }
            catch
            {
                cbPresentation.Enabled = false;
                btnClear.Enabled = false;
                btnSave.Enabled = false;
                btnRandomBarcode.Enabled = false;
                MessageBox.Show("Imposible cargar el listado de presentaciones de productos. La creación de productos se encuentra deshabilitada. Debe tener presentaciones de productos registradas previamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateAllFields())
            {
                Product product = new Product
                {
                    Barcode = txtBarcode.Text.Trim().ToUpper(),
                    Name = txtName.Text.Trim().ToUpper(),
                    Description = txtDescription.Text.Trim().ToUpper(),
                    BuyPrice = nudBuyPrice.Value,
                    SellPrice = nudSellPrice.Value,
                    Profit = nudSellPrice.Value - nudBuyPrice.Value,
                    Stock = (int)nudStock.Value,
                    StockMin = (int)nudStockMin.Value,
                    SupplierId = ((Supplier)cbSupplier.SelectedItem).Id,
                    PresentationId = ((Presentation)cbPresentation.SelectedItem).Id,
                    IsVisible = true,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                try
                {
                    ProductService productService = new ProductService(DB_CONTEXT);
                    var savedProduct = productService.CreateProduct(product);
                    MessageBox.Show($"Producto: {savedProduct.Name} creado exitosamente. Asignado ID: {savedProduct.Id} y Código de Barras: {savedProduct.Barcode}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearFields();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
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
                errorProvider.SetError(txtBarcode, "El código de barras ya existe en otro producto.");
                return false;
            }
            errorProvider.SetError(txtBarcode, "");
            return true;
        }

        private bool ValidateAllFields()
        {
            bool isValid = true;

            if (!ValidateBarcode()) isValid = false;
            if (ValidateBarcode())
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
            //TODO: Add IGV.
            if (ValidateBuyPrice() && ValidateSellPrice())
            {
                decimal buyPrice = nudBuyPrice.Value;
                decimal sellPrice = nudSellPrice.Value;
                if (buyPrice > 0)
                {
                    decimal profit = sellPrice - buyPrice;
                    txtProfit.Text = $"{profit:F2}";
                }
                else
                {
                    txtProfit.Text = "---";
                }
            }
            else
            {
                txtProfit.Text = "---";
            }
        }

        private void ClearFields()
        {
            txtBarcode.Clear();
            txtName.Clear();
            txtDescription.Clear();
            nudBuyPrice.Value = 0;
            nudSellPrice.Value = 0;
            nudStock.Value = 1;
            nudStockMin.Value = 1;
            txtProfit.Text = "---";
            if (cbSupplier.Items.Count > 0)
            {
                cbSupplier.SelectedIndex = 0;
            }
            if (cbPresentation.Items.Count > 0)
            {
                cbPresentation.SelectedIndex = 0;
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
