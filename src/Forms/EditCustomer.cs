using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using kiosko_ssms.Services;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class EditCustomer : Krypton.Toolkit.KryptonForm
    {
        private int selectedCustomerId = 0;
        public EditCustomer()
        {
            InitializeComponent();
            txtKeyword.CausesValidation = false;
            btnReset.CausesValidation = false;
            btnSearch.CausesValidation = false;
        }

        public void HandleInfoFields(bool isEnabled)
        {
            txtNames.Enabled = isEnabled;
            txtSurnames.Enabled = isEnabled;
            txtDni.Enabled = isEnabled;
            txtPhoneNumber.Enabled = isEnabled;
            txtAddress.Enabled = isEnabled;
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
            txtNames.Clear();
            txtSurnames.Clear();
            txtDni.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
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

        private bool ValidateDni(TextBox field)
        {
            string dni = field.Text.Trim();
            if (string.IsNullOrWhiteSpace(dni))
            {
                errorProvider.SetError(field, "Debe ingresar un DNI.");
                return false;
            }
            if (!Regex.IsMatch(dni, @"^.*\S.*$"))
            {
                errorProvider.SetError(field, "El DNI no puede ser solo espacios en blanco.");
                return false;
            }
            if (!Regex.IsMatch(dni, @"^\S.*$"))
            {
                errorProvider.SetError(field, "El DNI no debe comenzar con espacios en blanco.");
                return false;
            }
            if (!Regex.IsMatch(dni, @"^[0-9]{7,15}$"))
            {
                errorProvider.SetError(field, "El DNI solo debe contener números.");
                return false;
            }
            errorProvider.SetError(field, "");
            return true;
        }

        private bool ValidateDni(Krypton.Toolkit.KryptonTextBox field)
        {
            string dni = field.Text.Trim();
            if (string.IsNullOrWhiteSpace(dni))
            {
                errorProvider.SetError(field, "Debe ingresar un DNI.");
                return false;
            }
            if (!Regex.IsMatch(dni, @"^.*\S.*$"))
            {
                errorProvider.SetError(field, "El DNI no puede ser solo espacios en blanco.");
                return false;
            }
            if (!Regex.IsMatch(dni, @"^\S.*$"))
            {
                errorProvider.SetError(field, "El DNI no debe comenzar con espacios en blanco.");
                return false;
            }
            if (!Regex.IsMatch(dni, @"^[0-9]{7,15}$"))
            {
                errorProvider.SetError(field, "El DNI solo debe contener números.");
                return false;
            }
            errorProvider.SetError(field, "");
            return true;
        }

        private bool ValidateSearch()
        {
            if (!ValidateDni(txtKeyword))
            {
                return false;
            }
            return true;
        }

        private void SearchCustomer(string dni)
        {
            using (var context = new AppDbContext())
            {
                CustomerService customerService = new CustomerService(context);
                var customers = customerService.GetCustomersByDni(dni, true);
                if (customers.Count <= 0)
                {
                    MessageBox.Show("No se encontró ningún cliente con el DNI proporcionado.", "Cliente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtKeyword.Focus();
                    ClearFields();
                    return;
                }
                else
                {
                    FillFields(customers[0]);
                }
            }
        }

        private void FillFields(Customer customer)
        {
            selectedCustomerId = customer.Id;
            txtNames.Text = customer.Names;
            txtSurnames.Text = customer.Surnames;
            txtDni.Text = customer.Dni;
            txtPhoneNumber.Text = customer.PhoneNumber;
            txtAddress.Text = customer.Address;
            txtEmail.Text = customer.Email;
            chkIsDeleted.Checked = customer.IsDeleted;
            HandleInfoFields(true);
            HandleSearchFields(false);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (ValidateSearch())
            {
                SearchCustomer(txtKeyword.Text.Trim());
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
            HandleInfoFields(false);
            HandleSearchFields(true);
            selectedCustomerId = 0;
            txtKeyword.Clear();
            txtKeyword.Focus();
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

        private bool ValidateExistingDni(string dni)
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

        private bool ValidateEditFields()
        {
            bool isValid = true;
            if (!ValidateNames()) isValid = false;
            if (!ValidateSurnames()) isValid = false;
            if (!ValidateDni(txtDni))
            {
                if (!ValidateExistingDni(txtDni.Text?.Trim())) isValid = false;
            }
            if (!ValidatePhoneNumber()) isValid = false;
            if (!ValidateAddress()) isValid = false;
            if (!ValidateEmail()) isValid = false;
            return isValid;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateEditFields())
            {
                Customer customer = new Customer
                {
                    Id = selectedCustomerId,
                    Names = txtNames.Text,
                    Surnames = txtSurnames.Text,
                    Dni = txtDni.Text.Trim(),
                    PhoneNumber = txtPhoneNumber.Text,
                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                    IsDeleted = chkIsDeleted.Checked ? true : false,
                    UpdatedAt = DateTime.UtcNow
                };
                try
                {
                    using (var context = new AppDbContext())
                    {
                        var updatedCustomer = new CustomerService(context).UpdateCustomer(customer);
                        MessageBox.Show($"Cliente {updatedCustomer.Names} {updatedCustomer.Surnames} actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        HandleInfoFields(false);
                        HandleSearchFields(true);
                        selectedCustomerId = 0;
                        txtKeyword.Clear();
                        txtKeyword.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }


    }
}
