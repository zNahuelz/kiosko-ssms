using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using kiosko_ssms.Services;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class EditPresentation : Krypton.Toolkit.KryptonForm
    {
        int selectedPresentationId = 0;
        public EditPresentation()
        {
            InitializeComponent();
            btnReset.CausesValidation = false;
            btnSearch.CausesValidation = false;
            txtKeyword.CausesValidation = false;
        }

        private void EditPresentation_Load(object sender, EventArgs e)
        {
            HandleInfoFields(false);
            HandleSearchFields(true);
        }

        private void HandleInfoFields(bool isEnabled)
        {
            txtName.Enabled = isEnabled;
            nudQuantity.Enabled = isEnabled;
            txtUnit.Enabled = isEnabled;
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
            txtUnit.Clear();
            nudQuantity.Value = 1;
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

        private bool ValidateSearch()
        {
            try
            {
                if (int.Parse(txtKeyword.Text?.Trim()) >= 1)
                {
                    return true;
                }
                else { return false; }
            }
            catch
            {
                return false;
            }
        }

        private void SearchPresentation(int id)
        {
            using (var context = new AppDbContext())
            {
                PresentationService presentationService = new PresentationService(context);
                var presentations = presentationService.GetPresentationsById(id, true);
                if (presentations.Count <= 0)
                {
                    MessageBox.Show("No se encontró ninguna presentación con el ID proporcionado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtKeyword.Focus();
                    ClearFields();
                    return;
                }
                else
                {
                    FillFields(presentations[0]);
                }
            }
        }

        private void FillFields(Presentation presensation)
        {
            selectedPresentationId = presensation.Id;
            txtName.Text = presensation.Name;
            nudQuantity.Value = (decimal)presensation.Quantity;
            txtUnit.Text = presensation.Unit;
            chkIsDeleted.Checked = presensation.IsDeleted;
            HandleInfoFields(true);
            HandleSearchFields(false);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (ValidateSearch())
            {
                SearchPresentation(int.Parse(txtKeyword.Text?.Trim()));
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
            HandleInfoFields(false);
            HandleSearchFields(true);
            selectedPresentationId = 0;
            txtKeyword.Clear();
            txtKeyword.Focus();
        }

        private bool ValidateName()
        {
            string name = txtName.Text?.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(name))
            {
                errorProvider.SetError(txtName, "Debe ingresar un nombre.");
                return false;
            }
            if (name.Length < 3 || name.Length > 30)
            {
                errorProvider.SetError(txtName, "El nombre debe tener entre 3 y 30 caracteres.");
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

        private bool ValidateQuantity()
        {
            if (nudQuantity.Value <= (decimal)0.1)
            {
                errorProvider.SetError(nudQuantity, "La cantidad debe ser mayor a cero.");
                return false;
            }
            if (nudQuantity.Value >= 99999)
            {
                errorProvider.SetError(nudQuantity, "La cantidad debe ser menor a 99999.");
                return false;
            }
            errorProvider.SetError(nudQuantity, "");
            return true;
        }

        private bool ValidateUnit()
        {
            string unit = txtUnit.Text?.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(unit))
            {
                errorProvider.SetError(txtUnit, "Debe ingresar una unidad.");
                return false;
            }
            if (unit.Length < 2 || unit.Length > 30)
            {
                errorProvider.SetError(txtUnit, "La unidad debe tener entre 1 y 30 caracteres.");
                return false;
            }
            if (!Regex.IsMatch(unit, @"^.*\S.*$"))
            {
                errorProvider.SetError(txtUnit, "La unidad no puede ser solo espacios en blanco.");
                return false;
            }
            if (!Regex.IsMatch(unit, @"^\S.*$"))
            {
                errorProvider.SetError(txtUnit, "La unidad no debe comenzar con espacios en blanco.");
                return false;
            }
            errorProvider.SetError(txtUnit, "");
            return true;
        }

        private bool ValidatePresentationUniqueness()
        {
            string name = txtName.Text?.Trim().ToUpper();
            string unit = txtUnit.Text?.Trim().ToUpper();
            decimal quantity = nudQuantity.Value;

            using (var context = new AppDbContext())
            {
                bool exists = context.Presentations.Any(p =>
                    p.Id != selectedPresentationId &&
                    p.Name.ToUpper() == name &&
                    p.Unit.ToUpper() == unit &&
                    (decimal)p.Quantity == quantity);

                return !exists;
            }
        }

        private bool ValidateAllFields()
        {
            bool isValid = true;
            if (!ValidateName()) isValid = false;
            if (!ValidateQuantity()) isValid = false;
            if (!ValidateUnit()) isValid = false;
            if (!ValidatePresentationUniqueness())
            {
                MessageBox.Show("Ya existe una presentación con el mismo nombre, cantidad y unidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }
            return isValid;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateAllFields())
            {
                Presentation presentation = new Presentation
                {
                    Id = selectedPresentationId,
                    Name = txtName.Text,
                    Quantity = (double)nudQuantity.Value,
                    Unit = txtUnit.Text,
                    IsDeleted = chkIsDeleted.Checked ? true : false,
                    UpdatedAt = DateTime.UtcNow
                };

                try
                {
                    using (var context = new AppDbContext())
                    {
                        var updatedPresentation = new PresentationService(context).UpdatePresentation(presentation);
                        MessageBox.Show($"Presentación '{updatedPresentation.Name}' actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        HandleInfoFields(false);
                        HandleSearchFields(true);
                        selectedPresentationId = 0;
                        txtKeyword.Clear();
                        txtKeyword.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al actualizar la presentación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

    }
}

