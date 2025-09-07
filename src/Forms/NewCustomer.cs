using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using kiosko_ssms.Services;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class NewCustomer : Krypton.Toolkit.KryptonForm
    {
        public NewCustomer()
        {
            InitializeComponent();
            btnClear.CausesValidation = false;
        }

        private void ClearFields()
        {
            txtNames.Clear();
            txtSurnames.Clear();
            txtDni.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtNames.Focus();
        }

        private bool ValidateNames()
        {
            string name = txtNames.Text.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(name))
            {
                errorProvider.SetError(txtNames, "Debe ingresar un nombre.");
                return false;
            }
            if (name.Length < 2 || name.Length > 30)
            {
                errorProvider.SetError(txtNames, "El nombre debe tener entre 2 y 30 caracteres.");
                return false;
            }
            if (!Regex.IsMatch(name, @"^.*\S.*$"))
            {
                errorProvider.SetError(txtNames, "El nombre no puede ser solo espacios en blanco.");
                return false;
            }
            if (!Regex.IsMatch(name, @"^\S.*$"))
            {
                errorProvider.SetError(txtNames, "El nombre no debe comenzar con espacios en blanco.");
                return false;
            }
            if (!Regex.IsMatch(name, @"^[a-zA-ZáéíóúüñÁÉÍÓÚÜÑ\s]{2,30}$"))
            {
                errorProvider.SetError(txtNames, "El nombre solo debe contener letras mayúsculas y espacios.");
                return false;
            }

            errorProvider.SetError(txtNames, "");
            return true;
        }

        private bool ValidateSurnames()
        {
            string surnames = txtSurnames.Text.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(surnames))
            {
                errorProvider.SetError(txtSurnames, "Debe ingresar un apellido.");
                return false;
            }
            if (surnames.Length < 2 || surnames.Length > 30)
            {
                errorProvider.SetError(txtSurnames, "El apellido debe tener entre 2 y 30 caracteres.");
                return false;
            }
            if (!Regex.IsMatch(surnames, @"^.*\S.*$"))
            {
                errorProvider.SetError(txtSurnames, "El apellido no puede ser solo espacios en blanco.");
                return false;
            }
            if (!Regex.IsMatch(surnames, @"^\S.*$"))
            {
                errorProvider.SetError(txtSurnames, "El apellido no debe comenzar con espacios en blanco.");
                return false;
            }
            if (!Regex.IsMatch(surnames, @"^[a-zA-ZáéíóúüñÁÉÍÓÚÜÑ\s]{2,30}$"))
            {
                errorProvider.SetError(txtSurnames, "El apellido solo debe contener letras mayúsculas y espacios.");
                return false;
            }
            errorProvider.SetError(txtSurnames, "");
            return true;
        }

        private bool ValidateDni()
        {
            string dni = txtDni.Text.Trim();
            if (string.IsNullOrWhiteSpace(dni))
            {
                errorProvider.SetError(txtDni, "Debe ingresar un DNI.");
                return false;
            }
            if (!Regex.IsMatch(dni, @"^.*\S.*$"))
            {
                errorProvider.SetError(txtDni, "El DNI no puede ser solo espacios en blanco.");
                return false;
            }
            if (!Regex.IsMatch(dni, @"^\S.*$"))
            {
                errorProvider.SetError(txtDni, "El DNI no debe comenzar con espacios en blanco.");
                return false;
            }
            if (!Regex.IsMatch(dni, @"^[0-9]{7,15}$"))
            {
                errorProvider.SetError(txtDni, "El DNI solo debe contener números.");
                return false;
            }
            errorProvider.SetError(txtDni, "");
            return true;
        }

        private bool ValidateDniUnique(string dni)
        {
            using (var context = new AppDbContext())
            {
                var customers = new CustomerService(context).GetCustomersByDni(dni, true);

                if (customers.Count >= 1)
                {
                    errorProvider.SetError(txtDni, "Ya existe un cliente registrado con el DNI ingresado.");
                    return false;
                }
            }
            errorProvider.SetError(txtDni, "");
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
            if (!ValidateNames()) isValid = false;
            if (!ValidateSurnames()) isValid = false;
            if (!ValidateDni()) isValid = false;
            if (!ValidateDniUnique(txtDni.Text?.Trim())) isValid = false;
            if (!ValidateAddress()) isValid = false;
            if (!ValidatePhoneNumber()) isValid = false;
            if (!ValidateEmail()) isValid = false;
            return isValid;
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
                    Customer customer = new Customer
                    {
                        Names = txtNames.Text,
                        Surnames = txtSurnames.Text,
                        Dni = txtDni.Text,
                        Address = txtAddress.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                        Email = txtEmail.Text,
                        IsDeleted = false,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    };
                    using (var context = new AppDbContext())
                    {
                        var savedCustomer = new CustomerService(context).CreateCustomer(customer);
                        MessageBox.Show($"Cliente {savedCustomer.Names} {savedCustomer.Surnames} guardado exitosamente. Asignado ID: {savedCustomer.Id}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al guardar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
