using kiosko_ssms.Data.Entities;
using kiosko_ssms.Services;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class NewSupplier : Krypton.Toolkit.KryptonForm
    {
        public NewSupplier()
        {
            InitializeComponent();
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

        private bool ValidateRuc()
        {
            string ruc = txtRuc.Text.Trim();
            if (string.IsNullOrWhiteSpace(ruc))
            {
                errorProvider.SetError(txtRuc, "Debe ingresar un RUC.");
                return false;
            }

            if (!Regex.IsMatch(ruc, @"^(10|20)[0-9]{9}$"))
            {
                errorProvider.SetError(txtRuc, "El RUC debe comenzar con 10 o 20 y tener 11 dígitos en total.");
                return false;
            }
            errorProvider.SetError(txtRuc, "");
            return true;
        }

        private bool ValidateRucUnique(string ruc)
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

        private bool ValidateAllFields()
        {
            bool isValid = true;

            if (!ValidateName()) isValid = false;
            if (!ValidateRuc()) isValid = false;
            if (!ValidateRucUnique(txtRuc.Text?.Trim())) isValid = false;
            if (!ValidateDescription()) isValid = false;
            if (!ValidateAddress()) isValid = false;
            if (!ValidatePhoneNumber()) isValid = false;
            if (!ValidateEmail()) isValid = false;
            return isValid;
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtRuc.Clear();
            txtDescription.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateAllFields())
            {
                try
                {
                    Supplier supplier = new Supplier
                    {
                        Name = txtName.Text,
                        Ruc = txtRuc.Text,
                        Description = string.IsNullOrWhiteSpace(txtDescription.Text) ? null : txtDescription.Text,
                        Address = string.IsNullOrWhiteSpace(txtAddress.Text) ? null : txtAddress.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                        Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text,
                        IsDeleted = false,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                    };

                    using (var context = new Data.AppDbContext())
                    {
                        var savedSupplier = new SupplierService(context).CreateSupplier(supplier);
                        MessageBox.Show($"Proveedor '{savedSupplier.Name}' creado con éxito. Asignado ID: {savedSupplier.Id}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearFields();
                }
            }
        }
    }
}
