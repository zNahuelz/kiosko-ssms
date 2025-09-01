using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using kiosko_ssms.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class ProductList : Krypton.Toolkit.KryptonForm
    {
        public ProductList()
        {
            InitializeComponent();
        }

        private readonly AppDbContext DB_CONTEXT = new Data.AppDbContext();
        private List<Product> products = new List<Product>();

        private void ProductList_Load(object sender, EventArgs e)
        {
            FillSearchModes();
            FillSuppliersCombo();
            FillPresentationsCombo();
            FillProductsTable();
            txtSearch.Focus();
        }

        private void ConfigureTable(DataGridView dgv)
        {
            dgv.Columns[4].Visible = false;
            dgv.Columns[6].Visible = false;
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].Visible = false;
            dgv.Columns[10].Visible = false;
            dgv.Columns[12].Visible = false;
            dgv.Columns[13].Visible = false;
            dgv.Columns[14].Visible = false;

            dgv.Columns[0].Width = 50;
            dgv.Columns[1].Width = 250;
            dgv.Columns[2].Width = 30;
            dgv.Columns[3].Width = 100;
            dgv.Columns[5].Width = 60;
            dgv.Columns[11].Width = 120;
            dgv.Columns[14].Width = 150;
            dgv.Columns[15].Width = 150;

            dgv.Columns[0].HeaderText = "#";
            dgv.Columns[1].HeaderText = "NOMBRE";
            dgv.Columns[2].HeaderText = "DESCRIPCIÓN";
            dgv.Columns[3].HeaderText = "COD. BARRAS";
            dgv.Columns[5].HeaderText = "PCO. VENTA";
            dgv.Columns[7].HeaderText = "STOCK";
            dgv.Columns[11].HeaderText = "ULT. MOD.";
            dgv.Columns[15].HeaderText = "PRESENTACIÓN";
            dgv.Columns[16].HeaderText = "PROVEEDOR";

            dgv.Columns[5].DefaultCellStyle.ForeColor = Color.Green;

            dgv.Columns[5].DefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
            dgvProducts.CellFormatting += dgvProducts_CellFormatting;
        }

        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProducts.Columns[e.ColumnIndex].DataPropertyName == "Supplier" && e.Value is Supplier supplier)
            {
                e.Value = supplier.Name;
            }
            if (dgvProducts.Columns[e.ColumnIndex].DataPropertyName == "Presentation" && e.Value is Presentation presentation)
            {
                e.Value = presentation.Name != "Unidad" ? $"{presentation.Name} {presentation.Quantity} {presentation.Unit}" : presentation.Name;
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProducts.CurrentRow.Selected = true;
        }

        private void FillSearchModes()
        {
            cbSearchMode.DataSource = Utils.Constants.ProductSearchModes;
        }

        private void FillSuppliersCombo()
        {
            try
            {
                SupplierService _supplierService = new SupplierService(DB_CONTEXT);
                cbSuppliers.DataSource = _supplierService.GetAllSuppliers(false);
                cbSuppliers.DisplayMember = "Name";

            }
            catch
            {
                cbSuppliers.Enabled = false;
                MessageBox.Show("Imposible cargar el listado de proveedores. La busqueda de productos por esta característica se encuentra deshabilitada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillPresentationsCombo()
        {
            try
            {
                PresentationService _presentationService = new PresentationService(DB_CONTEXT);
                cbPresentations.DataSource = _presentationService.getAllPresentations(false);
            }
            catch
            {
                cbPresentations.Enabled = false;
                MessageBox.Show("Imposible cargar el listado de presentaciones de productos. La busqueda de productos por esta característica se encuentra deshabilitada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillProductsTable(string mode = "")
        {
            try
            {
                switch (mode)
                {
                    case "BY_NAME":
                        products = new ProductService(DB_CONTEXT).GetProductsByName(txtSearch.Text.Trim().ToUpper());
                        break;
                    case "BY_BARCODE":
                        products = new ProductService(DB_CONTEXT).GetProductsByBarcode(txtSearch.Text.Trim());
                        break;
                    case "BY_DESCRIPTION":
                        products = new ProductService(DB_CONTEXT).GetProductsByName(txtSearch.Text.Trim().ToUpper());
                        break;
                    case "BY_SUPPLIER":
                        if (cbSuppliers.SelectedItem is Supplier selectedSupplier)
                        {
                            products = new ProductService(DB_CONTEXT).GetProductsBySupplier(selectedSupplier.Id);
                        }
                        break;
                    case "BY_PRESENTATION":
                        if (cbPresentations.SelectedItem is Presentation selectedPresentation)
                        {
                            products = new ProductService(DB_CONTEXT).GetProductsByPresentation(selectedPresentation.Id);
                        }
                        break;
                    default:
                        products = new ProductService(DB_CONTEXT).GetAllProducts(false);
                        break;
                }
                dgvProducts.DataSource = products;
                ConfigureTable(dgvProducts);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbSearchMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbSearchMode.SelectedIndex)
            {
                case 0:
                    txtSearch.Enabled = true;
                    cbPresentations.Enabled = false;
                    cbSuppliers.Enabled = false;
                    break;
                case 1:
                    txtSearch.Enabled = true;
                    cbPresentations.Enabled = false;
                    cbSuppliers.Enabled = false;
                    break;
                case 2:
                    txtSearch.Enabled = true;
                    cbPresentations.Enabled = false;
                    cbSuppliers.Enabled = false;
                    break;
                case 3:
                    txtSearch.Enabled = false;
                    cbPresentations.Enabled = false;
                    cbSuppliers.Enabled = true;
                    break;
                case 4:
                    txtSearch.Enabled = false;
                    cbPresentations.Enabled = true;
                    cbSuppliers.Enabled = false;
                    break;
                default: break;
            }
            txtSearch.Clear();
            if (cbSuppliers.Items.Count > 0) cbSuppliers.SelectedIndex = 0;
            if (cbPresentations.Items.Count > 0) cbPresentations.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cbSearchMode.SelectedIndex)
            {
                case 0:
                    if (txtSearch.Text.ToString().Trim().Length >= 3)
                    {
                        FillProductsTable("BY_NAME");
                    }
                    else
                    {
                        FillProductsTable();
                    }
                    break;
                case 1:
                    FillProductsTable("BY_BARCODE");
                    break;
                case 2:
                    if (txtSearch.Text.Length >= 3)
                    {
                        FillProductsTable("BY_DESCRIPTION");
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese al menos 3 caracteres para realizar la búsqueda por descripción.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case 3:
                    FillProductsTable("BY_SUPPLIER");
                    break;
                case 4:
                    FillProductsTable("BY_PRESENTATION");
                    break;
                default:
                    break;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSearch.PerformClick();
            }

            if (txtSearch.Text.Length >= 3 && (cbSearchMode.SelectedIndex == 0 || cbSearchMode.SelectedIndex == 2))
            {
                btnSearch.PerformClick();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FillProductsTable();
            txtSearch.Clear();
            cbSearchMode.SelectedIndex = 0;
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedProduct = dgvProducts.Rows[e.RowIndex].DataBoundItem as Product;
                if (selectedProduct != null)
                {
                    Main parent = this.MdiParent as Main;
                    if (parent != null)
                    {
                        parent.OpenForm(ref parent.productDetailForm,
                            (s, ev) => parent.CloseForm(ref parent.productDetailForm, s, ev));
                        parent.productDetailForm.LoadProduct(selectedProduct);
                    }
                }
            }
        }
    }
}
