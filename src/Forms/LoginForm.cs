using kiosko_ssms.Data;
using kiosko_ssms.Data.Migrations;
using kiosko_ssms.Services;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class LoginForm : Krypton.Toolkit.KryptonForm
    {
        private int counter = 0;
        public LoginForm()
        {
            InitializeComponent();
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

        private bool ValidatePassword()
        {
            string password = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(password))
            {
                errorProvider.SetError(txtPassword, "Debe ingresar una contraseña.");
                return false;
            }
            if (password.Length < 5 || password.Length > 20)
            {
                errorProvider.SetError(txtPassword, "La contraseña debe tener entre 5 y 20 caracteres.");
                return false;
            }
            errorProvider.SetError(txtPassword, "");
            return true;
        }

        private bool ValidateForm()
        {
            bool isEmailValid = ValidateEmail();
            bool isPasswordValid = ValidatePassword();
            return isEmailValid && isPasswordValid;
        }

        private void btnRecoverAccess_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    using (var context = new AppDbContext())
                    {
                        var userFromCredentials = new UserService(context).Login(txtEmail.Text.Trim().ToUpper(), txtPassword.Text);
                        if (userFromCredentials != null)
                        {
                            this.Hide();
                            Main mainForm = new Main(userFromCredentials);
                            mainForm.FormClosed += (s, args) => this.Close();
                            mainForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Correo electrónico o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al intentar iniciar sesión. Detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidateForm() && e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            counter += 1;
            if (counter >= 10)
            {
                MessageBox.Show($"Kiosko SSMS\nVersión 1.0.0\n\nUSUARIO: {new UserSeeder().Users[0].Email.ToUpper()} \n\nCONTRASEÑA: r00to", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
