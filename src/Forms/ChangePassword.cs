using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using kiosko_ssms.Services;
using System;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class ChangePassword : Krypton.Toolkit.KryptonForm
    {
        private User currentUser;
        public ChangePassword(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private bool ValidateCurrentPassword()
        {
            string password = txtCurrentPassword.Text;
            if (string.IsNullOrEmpty(password))
            {
                errorProvider.SetError(txtCurrentPassword, "Debe ingresar su contraseña actual.");
                return false;
            }
            if (password.Length < 5 || password.Length > 20)
            {
                errorProvider.SetError(txtCurrentPassword, "La contraseña actual debe tener entre 5 y 20 caracteres.");
                return false;
            }
            errorProvider.SetError(txtCurrentPassword, "");
            return true;
        }

        private bool ValidateNewPassword()
        {
            string password = txtNewPassword.Text;
            if (string.IsNullOrEmpty(password))
            {
                errorProvider.SetError(txtNewPassword, "Debe ingresar una nueva contraseña.");
                return false;
            }
            if (password.Length < 5 || password.Length > 20)
            {
                errorProvider.SetError(txtNewPassword, "La nueva contraseña debe tener entre 5 y 20 caracteres.");
                return false;
            }
            errorProvider.SetError(txtNewPassword, "");
            return true;
        }

        private bool ValidateRepeatPassword()
        {
            string repeatPassword = txtRepeatPassword.Text;
            if (string.IsNullOrEmpty(repeatPassword))
            {
                errorProvider.SetError(txtRepeatPassword, "Debe repetir la nueva contraseña.");
                return false;
            }

            if (repeatPassword != txtNewPassword.Text)
            {
                errorProvider.SetError(txtRepeatPassword, "Las contraseñas no coinciden.");
                return false;
            }

            errorProvider.SetError(txtRepeatPassword, "");
            return true;
        }

        private bool ValidateForm()
        {
            bool isCurrentValid = ValidateCurrentPassword();
            bool isNewValid = ValidateNewPassword();
            bool isRepeatValid = ValidateRepeatPassword();

            return isCurrentValid && isNewValid && isRepeatValid;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    using (var context = new AppDbContext())
                    {
                        var updatedUser = new UserService(context).ChangePassword(currentUser.Id, txtCurrentPassword.Text, txtNewPassword.Text);
                        MessageBox.Show("Contraseña actualizada exitosamente. Debe volver a iniciar sesión", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show($"No se encontró el usuario actual. Por favor, inicie sesión nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show($"Su contraseña actual no coincide, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al actualizar la contraseña: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void txtRepeatPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidateForm() && e.KeyChar == (char)Keys.Enter)
            {
                btnUpdate.PerformClick();
            }
        }
    }
}
