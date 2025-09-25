using System;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class Main : Krypton.Toolkit.KryptonForm
    {
        private NewProduct newProductForm;
        private ProductList productListForm;
        public ProductDetail productDetailForm;
        private EditProduct editProductForm;
        private SupplierList supplierListForm;
        public SupplierDetail supplierDetailForm;
        private NewSupplier newSupplierForm;
        private EditSupplier editSupplierForm;
        private CustomerList customerListForm;
        public CustomerDetail customerDetailForm;
        private NewCustomer newCustomerForm;
        private EditCustomer editCustomerForm;
        private NewPresentation newPresentationForm;
        private PresentationList presentationListForm;
        private EditPresentation editPresentationForm;
        private VoucherList voucherListForm;
        public VoucherDetail voucherDetailForm;
        private SalesReport salesReportForm;

        private NewSale newSaleForm;

        private About aboutForm;
        private Settings settingsForm;

        public Main()
        {
            InitializeComponent();
            tssDate.Text = $"FECHA ACTUAL: {DateTime.Now.ToString("dd/MM/yyyy")}";
            mainTimer.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void OpenForm<T>(ref T formInstance, FormClosedEventHandler formClosedHandler) where T : Form, new()
        {
            if (formInstance == null)
            {
                formInstance = new T
                {
                    MdiParent = this
                };
                formInstance.FormClosed += formClosedHandler;
                formInstance.Show();
            }
            else
            {
                formInstance.Focus();
            }
        }

        private void KillChildForms()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
            newProductForm = null;
            productListForm = null;
            productDetailForm = null;
            editProductForm = null;
        }

        public void CloseForm<T>(ref T formInstance, object sender, FormClosedEventArgs eventArgs) where T : Form
        {
            formInstance = null;
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            OpenForm(ref newProductForm, (s, ev) => CloseForm(ref newProductForm, s, ev));
        }

        private void btnProductsList_Click(object sender, EventArgs e)
        {
            OpenForm(ref productListForm, (s, ev) => CloseForm(ref productListForm, s, ev));
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            OpenForm(ref editProductForm, (s, ev) => CloseForm(ref editProductForm, s, ev));
        }

        private void btnSuppliersList_Click(object sender, EventArgs e)
        {
            OpenForm(ref supplierListForm, (s, ev) => CloseForm(ref supplierListForm, s, ev));
        }

        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
            OpenForm(ref newSupplierForm, (s, ev) => CloseForm(ref newSupplierForm, s, ev));
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            OpenForm(ref editSupplierForm, (s, ev) => CloseForm(ref editSupplierForm, s, ev));
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            OpenForm(ref customerListForm, (s, ev) => CloseForm(ref customerListForm, s, ev));
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            OpenForm(ref newCustomerForm, (s, ev) => CloseForm(ref newCustomerForm, s, ev));
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            OpenForm(ref editCustomerForm, (s, ev) => CloseForm(ref editCustomerForm, s, ev));
        }

        private void btnPresentationList_Click(object sender, EventArgs e)
        {
            OpenForm(ref presentationListForm, (s, ev) => CloseForm(ref presentationListForm, s, ev));
        }

        private void btnEditPresentation_Click(object sender, EventArgs e)
        {
            OpenForm(ref editPresentationForm, (s, ev) => CloseForm(ref editPresentationForm, s, ev));
        }

        private void btnNewPresentation_Click(object sender, EventArgs e)
        {
            OpenForm(ref newPresentationForm, (s, ev) => CloseForm(ref newPresentationForm, s, ev));
        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            OpenForm(ref newSaleForm, (s, ev) => CloseForm(ref newSaleForm, s, ev));
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            OpenForm(ref aboutForm, (s, ev) => CloseForm(ref aboutForm, s, ev));
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenForm(ref settingsForm, (s, ev) => CloseForm(ref settingsForm, s, ev));
        }

        private void btnVoucherList_Click(object sender, EventArgs e)
        {
            OpenForm(ref voucherListForm, (s, ev) => CloseForm(ref voucherListForm, s, ev));
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            OpenForm(ref salesReportForm, (s, ev) => CloseForm(ref salesReportForm, s, ev));
        }

        private void btnKillForms_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cerrar todas las herramientas de trabajo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                KillChildForms();
            }
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            tssClock.Text = $"HORA ACTUAL: {DateTime.Now.ToString("hh:mm:ss tt")}";
        }
    }
}
