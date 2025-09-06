using kiosko_ssms.Data.Entities;
using System;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class SupplierDetail : Krypton.Toolkit.KryptonForm
    {
        private Supplier _supplier;
        public SupplierDetail()
        {
            InitializeComponent();
        }

        public void LoadSupplier(Supplier supplier)
        {
            _supplier = supplier;
            txtId.Text = _supplier.Id.ToString();
            txtName.Text = _supplier.Name?.Trim().ToUpper();
            txtRuc.Text = _supplier.Ruc?.Trim();
            txtAddress.Text = _supplier.Address?.Trim().ToUpper();
            txtPhoneNumber.Text = _supplier.PhoneNumber?.Trim();
            txtEmail.Text = _supplier.Email?.Trim().ToUpper();
            txtDescription.Text = _supplier.Description?.ToUpper().Trim();
            txtIsDeleted.Text = _supplier.IsDeleted ? "ELIMINADO" : "NO ELIMINADO";
            txtCreatedAt.Text = _supplier.CreatedAt.ToString("g");
            txtUpdatedAt.Text = _supplier.UpdatedAt.ToString("g");
        }

        private void txtId_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(txtId.Text);
            tssLabel.Text = "ID copiado al portapapeles!";
        }

        private void txtRuc_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(txtRuc.Text);
            tssLabel.Text = "RUC copiado al portapapeles!";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
