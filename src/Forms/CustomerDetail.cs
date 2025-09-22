using kiosko_ssms.Data.Entities;
using kiosko_ssms.Utils;
using System;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class CustomerDetail : Krypton.Toolkit.KryptonForm
    {
        private Customer _customer;
        public CustomerDetail()
        {
            InitializeComponent();
        }

        public void LoadCustomer(Customer customer)
        {
            _customer = customer;
            txtId.Text = _customer.Id.ToString();
            txtNames.Text = _customer.Names?.Trim().ToUpper();
            txtSurnames.Text = _customer.Surnames?.Trim().ToUpper();
            txtDni.Text = _customer.Dni;
            txtPhoneNumber.Text = _customer.PhoneNumber;
            txtAddress.Text = _customer.Address?.ToUpper();
            txtEmail.Text = _customer.Email?.Trim().ToUpper();
            txtIsDeleted.Text = _customer.IsDeleted ? "ELIMINADO" : "NO ELIMINADO";
            txtCreatedAt.Text = _customer.CreatedAt.ToString("g");
            txtUpdatedAt.Text = _customer.UpdatedAt.ToString("g");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtId_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(txtId.Text);
            tssLabel.Text = Constants.Messages.Info.COPIED_ID;
        }

        private void txtDni_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(txtDni.Text);
            tssLabel.Text = Constants.Messages.Info.COPIED_DNI;
        }

        private void txtEmail_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(txtEmail.Text?.Trim().ToUpper());
            tssLabel.Text = Constants.Messages.Info.COPIED_EMAIL;
        }
    }
}
