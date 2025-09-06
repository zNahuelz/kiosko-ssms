using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using kiosko_ssms.Services;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class EditSupplier : Krypton.Toolkit.KryptonForm
    {
        int selectedSupplierId = 0;
        public EditSupplier()
        {
            InitializeComponent();
            btnReset.CausesValidation = false;
            btnSearch.CausesValidation = false;
            txtKeyword.CausesValidation = false;
        }

        private void HandleInfoFields(bool isEnabled)
        {
            txtName.Enabled = isEnabled;
            txtRuc.Enabled = isEnabled;
            txtDescription.Enabled = isEnabled;
            txtAddress.Enabled = isEnabled;
            txtPhoneNumber.Enabled = isEnabled;
            txtEmail.Enabled = isEnabled;
            chkIsDeleted.Enabled = isEnabled;
            btnUpdate.Enabled = isEnabled;
            btnReset.Enabled = isEnabled;
        }

        private void HandleSearchFields(bool isEnabled)
        {
            txtKeyword.Enabled = isEnabled;
            btnSearch.Enabled = isEnabled;
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtRuc.Clear();
            txtDescription.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            chkIsDeleted.Checked = false;
        }

        private void txtKeyword_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtKeyword.Text = Clipboard.GetText().Trim();
                btnSearch.PerformClick();
            }
            catch
            {
                txtKeyword.Text = "";
            }
        }

        private void txtKeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSearch.PerformClick();
            }
        }


        private bool ValidateRuc(TextBox field)
        {
            string ruc = field.Text.Trim();
            if (string.IsNullOrWhiteSpace(ruc))
            {
                errorProvider.SetError(field, "Debe ingresar un RUC.");
                return false;
            }

            if (!Regex.IsMatch(ruc, @"^(10|20)[0-9]{9}$"))
            {
                errorProvider.SetError(field, "El RUC debe comenzar con 10 o 20 y tener 11 dígitos en total.");
                return false;
            }
            errorProvider.SetError(field, "");
            return true;
        }

        private bool ValidateRuc(Krypton.Toolkit.KryptonTextBox field)
        {
            string ruc = field.Text.Trim();
            if (string.IsNullOrWhiteSpace(ruc))
            {
                errorProvider.SetError(field, "Debe ingresar un RUC.");
                return false;
            }
            if (!Regex.IsMatch(ruc, @"^(10|20)[0-9]{9}$"))
            {
                errorProvider.SetError(field, "El RUC debe comenzar con 10 o 20 y tener 11 dígitos en total.");
                return false;
            }
            errorProvider.SetError(field, "");
            return true;
        }

        private bool ValidateSearch()
        {
            if (!ValidateRuc(txtKeyword))
            {
                txtKeyword.Focus();
                return false;
            }
            return true;
        }

        private void SearchSupplier(string ruc)
        {
            using (var context = new AppDbContext())
            {
                SupplierService supplierService = new SupplierService(context);
                var suppliers = supplierService.GetSuppliersByRUC(ruc, true);
                if (suppliers.Count <= 0)
                {
                    MessageBox.Show("No se encontró ningún proveedor con el RUC proporcionado.", "Proveedor no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtKeyword.Focus();
                    ClearFields();
                    return;
                }
                else
                {
                    FillFields(suppliers[0]);
                }
            }
        }

        private void FillFields(Supplier supplier)
        {
            selectedSupplierId = supplier.Id;
            txtName.Text = supplier.Name;
            txtRuc.Text = supplier.Ruc;
            txtDescription.Text = supplier.Description;
            txtAddress.Text = supplier.Address;
            txtPhoneNumber.Text = supplier.PhoneNumber;
            txtEmail.Text = supplier.Email;
            chkIsDeleted.Checked = supplier.IsDeleted;
            HandleInfoFields(true);
            HandleSearchFields(false);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (ValidateSearch())
            {
                SearchSupplier(txtKeyword.Text.Trim());
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
            HandleInfoFields(false);
            HandleSearchFields(true);
            selectedSupplierId = 0;
            txtKeyword.Clear();
            txtKeyword.Focus();
        }

        private bool ValidateName()
        {
            string name = txtName.Text.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(name))
            {
                errorProvider.SetError(txtName, "Debe ingresar un nombre.");
                return false;
            }
            if (name.Length < 5 || name.Length > 150)
            {
                errorProvider.SetError(txtName, "El nombre debe tener entre 5 y 150 caracteres.");
                return false;
            }
            if (!Regex.IsMatch(name, @"^.*\S.*$"))
            {
                errorProvider.SetError(txtName, "El nombre no puede ser solo espacios en blanco.");
                return false;
            }
            if (!Regex.IsMatch(name, @"^\S.*$"))
            {
                errorProvider.SetError(txtName, "El nombre no debe comenzar con espacios en blanco.");
                return false;
            }

            errorProvider.SetError(txtName, "");
            return true;
        }

        private bool ValidateExistingRuc(string ruc)
        {
            using (var context = new Data.AppDbContext())
            {
                var suppliers = new SupplierService(context).GetSuppliersByRUC(ruc, true);

                if (suppliers.Count >= 1)
                {
                    errorProvider.SetError(txtRuc, "Ya existe un proveedor registrado con el RUC ingresado.");
                    return false;
                }
            }
            errorProvider.SetError(txtRuc, "");
            return true;
        }

        private bool ValidateDescription()
        {
            string description = txtDescription.Text.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(description))
            {
                errorProvider.SetError(txtDescription, "Debe ingresar una descripción.");
                return false;
            }

            if (!Regex.IsMatch(description, @"^\S.*$"))
            {
                errorProvider.SetError(txtDescription, "La descripción no debe comenzar con espacios en blanco.");
                return false;
            }


            if (description.Length <= 5 || description.Length >= 150)
            {
                errorProvider.SetError(txtDescription, "La descripción es opcional. Debe tener entre 5 y 150 caracteres.");
                return false;
            }

            errorProvider.SetError(txtDescription, "");
            return true;
        }

        private bool ValidateAddress()
        {
            string address = txtAddress.Text.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(address))
            {
                errorProvider.SetError(txtAddress, "Debe ingresar una dirección");
                return false;
            }

            if (!Regex.IsMatch(address, @"^\S.*$"))
            {
                errorProvider.SetError(txtAddress, "La dirección no debe comenzar con espacios en blanco.");
                return false;
            }

            if (address.Length <= 5 || address.Length >= 150)
            {
                errorProvider.SetError(txtAddress, "La dirección es opcional. Debe tener entre 5 y 150 caracteres.");
                return false;
            }

            errorProvider.SetError(txtAddress, "");
            return true;
        }

        private bool ValidatePhoneNumber()
        {
            string phone = txtPhoneNumber.Text.Trim();

            if (string.IsNullOrEmpty(phone))
            {
                errorProvider.SetError(txtPhoneNumber, "Debe ingresar un número de teléfono.");
                return false;
            }

            if (!Regex.IsMatch(phone, @"^\+?\d{5,15}$"))
            {
                errorProvider.SetError(txtPhoneNumber, "El teléfono debe contener solo números, opcionalmente comenzar con +, y tener entre 5 y 15 dígitos.");
                return false;
            }

            errorProvider.SetError(txtPhoneNumber, "");
            return true;
        }

        private bool ValidateEmail()
        {
            string email = txtEmail.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(email))
            {
                errorProvider.SetError(txtEmail, "Debe ingresar un correo electrónico.");
                return false;
            }
            if (email.Length > 50)
            {
                errorProvider.SetError(txtEmail, "El correo no debe tener más de 50 caracteres.");
                return false;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider.SetError(txtEmail, "Ingrese un correo electrónico válido: EMAIL@DOMINIO.COM");
                return false;
            }

            errorProvider.SetError(txtEmail, "");
            return true;
        }

        private bool ValidateEditFields()
        {
            bool isValid = true;

            if (!ValidateName()) isValid = false;
            if (!ValidateRuc(txtRuc))
            {
                if (!ValidateExistingRuc(txtRuc.Text.Trim())) isValid = false;
            }
            if (!ValidateDescription()) isValid = false;
            if (!ValidateAddress()) isValid = false;
            if (!ValidatePhoneNumber()) isValid = false;
            if (!ValidateEmail()) isValid = false;
            return isValid;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateEditFields())
            {
                Supplier supplier = new Supplier
                {
                    Id = selectedSupplierId,
                    Name = txtName.Text,
                    Ruc = txtRuc.Text,
                    Description = txtDescription.Text,
                    Address = txtAddress.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Email = txtEmail.Text,
                    IsDeleted = chkIsDeleted.Checked ? true : false,
                    UpdatedAt = DateTime.UtcNow
                };

                try
                {
                    using (var context = new AppDbContext())
                    {
                        var updatedSupplier = new SupplierService(context).UpdateSupplier(supplier);
                        MessageBox.Show($"Proveedor '{updatedSupplier.Name}' actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        HandleInfoFields(false);
                        HandleSearchFields(true);
                        selectedSupplierId = 0;
                        txtKeyword.Clear();
                        txtKeyword.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
