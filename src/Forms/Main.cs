using System;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class Main : Krypton.Toolkit.KryptonForm
    {
        private NewProduct newProductForm;
        private ProductList productListForm;
        public ProductDetail productDetailForm;

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
    }
}
