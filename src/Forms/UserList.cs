using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using kiosko_ssms.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class UserList : Krypton.Toolkit.KryptonForm
    {
        List<User> users = new List<User>();
        public UserList()
        {
            InitializeComponent();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            FillUsers();
        }

        private void FillUsers()
        {
            using (var context = new AppDbContext())
            {
                users = new UserService(context).GetAllUsers(true);
            }
            dgvUser.DataSource = users;
            if (users.Any())
            {
                ConfigureTable(dgvUser);
            }
            else
            {
                lblMessage.Text = "No hay usuarios registrados.";
            }
        }

        private void ConfigureTable(DataGridView dgv)
        {
            dgv.Columns[0].HeaderText = "#";
            dgv.Columns[1].HeaderText = "NOMBRES";
            dgv.Columns[2].HeaderText = "APELLIDOS";
            dgv.Columns[3].HeaderText = "DOC. ID.";
            dgv.Columns[4].HeaderText = "TELÉFONO";
            dgv.Columns[5].HeaderText = "DIRECCIÓN";
            dgv.Columns[6].HeaderText = "E-MAIL";
            dgv.Columns[8].HeaderText = "¿ELIMINADO?";
            dgv.Columns[9].HeaderText = "REGISTRO";
            dgv.Columns[10].HeaderText = "ULT. MOD.";
            dgv.Columns[12].HeaderText = "ROL";

            dgv.Columns[7].Visible = false;
            dgv.Columns[11].Visible = false;
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvUser.CurrentRow.Selected = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            users.Clear();
            FillUsers();
        }

        private void dgvUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUser.Columns[e.ColumnIndex].DataPropertyName == "Role" && e.Value is Role role)
            {
                e.Value = role.Name;
            }
        }

        private void btnMakeManager_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count > 0)
            {
                var user = (User)dgvUser.SelectedRows[0].DataBoundItem;
                if (user.Id == 1)
                {
                    MessageBox.Show("No se puede cambiar el rol del usuario administrador.", "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult result = MessageBox.Show($"¿Está seguro de asignar el rol de 'GERENTE' al usuario {user.Names} {user.Surnames}?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (var context = new AppDbContext())
                        {
                            var updatedUser = new UserService(context).ChangeRole(user.Id, "GERENTE");
                            if (updatedUser != null)
                            {
                                MessageBox.Show($"El rol del usuario {user.Names} {user.Surnames} ha sido actualizado a 'GERENTE'.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FillUsers();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al intentar cambiar el rol del usuario. Detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnMakeSeller_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count > 0)
            {
                var user = (User)dgvUser.SelectedRows[0].DataBoundItem;
                if (user.Id == 1)
                {
                    MessageBox.Show("No se puede cambiar el rol del usuario administrador.", "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult result = MessageBox.Show($"¿Está seguro de asignar el rol de 'VENDEDOR' al usuario {user.Names} {user.Surnames}?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (var context = new AppDbContext())
                        {
                            var updatedUser = new UserService(context).ChangeRole(user.Id, "VENDEDOR");
                            if (updatedUser != null)
                            {
                                MessageBox.Show($"El rol del usuario {user.Names} {user.Surnames} ha sido actualizado a 'VENDEDOR'.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FillUsers();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al intentar cambiar el rol del usuario. Detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEnableUser_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count > 0)
            {
                var user = (User)dgvUser.SelectedRows[0].DataBoundItem;
                DialogResult result = MessageBox.Show($"¿Está seguro de habilitar al usuario {user.Names} {user.Surnames}?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (var context = new AppDbContext())
                        {
                            var updatedUser = new UserService(context).HandleUserStatus(user.Id, false);
                            if (updatedUser != null)
                            {
                                MessageBox.Show($"El usuario {user.Names} {user.Surnames} ha sido habilitado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FillUsers();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al intentar habilitar al usuario. Detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDisableUser_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count > 0)
            {
                var user = (User)dgvUser.SelectedRows[0].DataBoundItem;
                if (user.Id == 1)
                {
                    MessageBox.Show("No se puede deshabilitar la cuenta de administrador.", "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult result = MessageBox.Show($"¿Está seguro de deshabilitar al usuario {user.Names} {user.Surnames}?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (var context = new AppDbContext())
                        {
                            var updatedUser = new UserService(context).HandleUserStatus(user.Id, true);
                            if (updatedUser != null)
                            {
                                MessageBox.Show($"El usuario {user.Names} {user.Surnames} ha sido deshabilitado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FillUsers();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al intentar deshabilitar al usuario. Detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count > 0)
            {
                var user = (User)dgvUser.SelectedRows[0].DataBoundItem;
                DialogResult result = MessageBox.Show($"¿Está seguro de restablecer la contraseña del usuario {user.Names} {user.Surnames}?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (var context = new AppDbContext())
                        {
                            var updatedUser = new UserService(context).ResetPassword(user.Id);
                            if (updatedUser != null)
                            {
                                MessageBox.Show($"La contraseña del usuario {user.Names} {user.Surnames} ha sido restablecida exitosamente. \nEl usuario puede iniciar sesión con su E-MAIL y su nueva contraseña, conformada por su DOC. ID. + AÑO de reseteo de contraseña. \nEJEMPLO: DNI: 01299887 - CONTRASEÑA: 012998872025", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FillUsers();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al intentar restablecer la contraseña del usuario. Detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvUser_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvUser.ClearSelection();
                dgvUser.Rows[e.RowIndex].Selected = true;
                dgvUser.CurrentCell = dgvUser.Rows[e.RowIndex].Cells[e.ColumnIndex];
                contextMenu.Show(Cursor.Position);
            }
        }
    }
}
