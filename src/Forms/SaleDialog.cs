using System;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class SaleDialog : Form
    {
        public double CashValue { get; private set; }
        public double ChangeValue { get; private set; }
        public double SaleValue { get; set; }
        public SaleDialog(double SaleValue)
        {
            InitializeComponent();
            this.SaleValue = SaleValue;
            lblSaleValue.Text = $"MONTO VENTA: {this.SaleValue}";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DoMath();
        }

        private void DoMath()
        {
            try
            {
                CashValue = Convert.ToDouble(txtCash.Text);
            }
            catch
            {
                errorProvider.SetError(txtCash, "El valor ingresado debe ser numérico.");
                txtCash.Clear();
                txtCash.Focus();
                return;
            }
            if (CashValue >= SaleValue)
            {
                ChangeValue = Math.Round(CashValue - SaleValue, 2);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                errorProvider.SetError(txtCash, "El efectivo no puede ser menor al valor de la venta.");
                txtCash.Clear();
                txtCash.Focus();
            }
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains("."))
            {
                return;
            }
            e.Handled = true;
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CashValue = Convert.ToDouble(txtCash.Text);
                ChangeValue = Math.Round(CashValue - SaleValue, 2);
                txtChange.Text = ChangeValue >= 0 ? ChangeValue.ToString() : "";
            }
            catch
            {
                txtChange.Text = "";
            }
        }
    }
}
