using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using kiosko_ssms.Services;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class EditPaymentType : Krypton.Toolkit.KryptonForm
    {
        private PaymentType paymentType = null;
        public EditPaymentType()
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

        private bool IsUniquePaymentType()
        {
            string name = txtName.Text?.Trim().ToUpper();
            using (var context = new AppDbContext())
            {
                var existing = new PaymentTypeService(context).GetPaymentTypesByName(name).FirstOrDefault();
                if (existing != null && existing.Id != paymentType.Id)
                {
                    errorProvider.SetError(txtName, "Ya existe un tipo de pago con este nombre.");
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

            return IsUniquePaymentType();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text.Trim());
                using (var context = new AppDbContext())
                {
                    paymentType = new PaymentTypeService(context).GetPaymentTypeById(id);
                    if (paymentType == null)
                    {
                        MessageBox.Show("No se encontró el tipo de pago con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        HandleEditFields(false);
                        HandleSearchFields(true);
                        txtId.Focus();
                        txtId.Clear();
                        return;
                    }
                    if (paymentType.Name.ToUpper() == "EFECTIVO")
                    {
                        MessageBox.Show("No se puede editar el tipo de pago 'EFECTIVO'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (paymentType != null)
            {
                txtName.Text = paymentType.Name;
                chkIsDeleted.Checked = paymentType.IsDeleted;
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
                        PaymentType updatedPaymentType = new PaymentTypeService(context).UpdatePaymentType(paymentType.Id, txtName.Text?.Trim().ToUpper(), chkIsDeleted.Checked);
                        MessageBox.Show($"Tipo de pago '{updatedPaymentType.Name}' actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al actualizar el tipo de pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            paymentType = null;
            txtId.Clear();
            txtName.Clear();
            chkIsDeleted.Checked = false;
            errorProvider.SetError(txtId, "");
            errorProvider.SetError(txtName, "");
            HandleEditFields(false);
            HandleSearchFields(true);
            txtId.Focus();
        }
    }
}
