using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using kiosko_ssms.Services;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class NewVoucherType : Krypton.Toolkit.KryptonForm
    {
        public NewVoucherType()
        {
            InitializeComponent();
        }

        private bool ValidateName()
        {
            string name = txtName.Text?.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(name))
            {
                errorProvider.SetError(txtName, "Debe ingresar un nombre.");
                return false;
            }
            if (name.Length < 5 || name.Length > 30)
            {
                errorProvider.SetError(txtName, "El nombre debe tener entre 5 y 30 caracteres.");
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

        private bool IsUniqueVoucherType()
        {
            string name = txtName.Text?.Trim().ToUpper();
            using (var context = new AppDbContext())
            {
                bool exists = new VoucherService(context).GetVoucherTypesByName(name).Any();
                if (exists)
                {
                    errorProvider.SetError(txtName, "El tipo de comprobante ya existe.");
                    return false;
                }
            }
            errorProvider.SetError(txtName, "");
            return true;
        }

        private bool ValidateForm()
        {
            if (!ValidateName())
                return false;

            return IsUniqueVoucherType();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    using (var context = new AppDbContext())
                    {
                        VoucherType savedVoucherType = new VoucherService(context).CreateVoucherType(txtName.Text?.Trim().ToUpper());
                        MessageBox.Show($"Tipo de comprobante '{savedVoucherType.Name}' guardado con éxito. Asignado ID: {savedVoucherType.Id}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClear.PerformClick();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el tipo de comprobante: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
        }
    }
}
