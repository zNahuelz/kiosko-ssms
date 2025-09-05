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

        public Main()
        {
            InitializeComponent();
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

        private void btnKillForms_Click(object sender, EventArgs e)
        {
            KillChildForms();
        }


    }
}
