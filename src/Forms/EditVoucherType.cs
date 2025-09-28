using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using kiosko_ssms.Services;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class EditVoucherType : Krypton.Toolkit.KryptonForm
    {
        private VoucherType voucherType = null;
        public EditVoucherType()
        {
            InitializeComponent();
            HandleEditFields(false);
            HandleSearchFields(true);
        }

        private void HandleEditFields(bool isEnabled)
        {
            txtName.Enabled = isEnabled;
            chkIsDeleted.Enabled = isEnabled;
            btnUpdate.Enabled = isEnabled;
            btnReset.Enabled = isEnabled;
        }

        private void HandleSearchFields(bool isEnabled)
        {
            txtId.Enabled = isEnabled;
            btnSearch.Enabled = isEnabled;
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
                var existing = new VoucherService(context).GetVoucherTypesByName(name).FirstOrDefault();

                if (existing != null && existing.Id != voucherType.Id)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text.Trim());
                using (var context = new AppDbContext())
                {
                    voucherType = new VoucherService(context).GetVoucherTypeById(id);
                    if (voucherType == null)
                    {
                        MessageBox.Show("No se encontró el tipo de comprobante con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        HandleEditFields(false);
                        HandleSearchFields(true);
                        txtId.Focus();
                        txtId.Clear();
                        return;
                    }
                    if (voucherType.Name.ToUpper() == "FACTURA" || voucherType.Name.ToUpper() == "BOLETA")
                    {
                        MessageBox.Show($"El tipo de comprobante '{voucherType.Name}' no puede ser modificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        HandleEditFields(false);
                        HandleSearchFields(true);
                        ResetForm();
                        return;
                    }
                    HandleEditFields(true);
                    HandleSearchFields(false);
                    FillFormFields();
                }
            }
            catch
            {
                errorProvider.SetError(txtId, "El ID ingresado debe ser numérico.");
            }
        }

        private void FillFormFields()
        {
            if (voucherType != null)
            {
                txtName.Text = voucherType.Name;
                chkIsDeleted.Checked = voucherType.IsDeleted;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    using (var context = new AppDbContext())
                    {
                        VoucherType updatedVoucherType = new VoucherService(context).UpdateVoucherType(voucherType.Id, txtName.Text?.Trim().ToUpper(), chkIsDeleted.Checked);
                        MessageBox.Show($"Tipo de comprobante '{updatedVoucherType.Name}' actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al actualizar el tipo de comprobante: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            voucherType = null;
            txtName.Clear();
            chkIsDeleted.Checked = false;
            txtId.Clear();
            errorProvider.Clear();
            HandleEditFields(false);
            HandleSearchFields(true);
        }
    }
}
