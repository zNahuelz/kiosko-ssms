using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using kiosko_ssms.Services;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class NewPresentation : Krypton.Toolkit.KryptonForm
    {
        public NewPresentation()
        {
            InitializeComponent();
            btnClear.CausesValidation = false;
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
                bool exists = context.Presentations.Any(p => p.Name.ToUpper() == name && p.Unit.ToUpper() == unit && (decimal)p.Quantity == quantity);
                return !exists;
            }
        }


        private void ClearFields()
        {
            txtName.Clear();
            nudQuantity.Value = 1;
            txtUnit.Clear();
            txtName.Focus();
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
                    Presentation presentation = new Presentation
                    {
                        Name = txtName.Text,
                        Quantity = (double)nudQuantity.Value,
                        Unit = txtUnit.Text,
                        IsDeleted = false,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    };
                    using (var context = new AppDbContext())
                    {
                        var savedPresentation = new PresentationService(context).CreatePresentation(presentation);
                        MessageBox.Show($"Presentación {savedPresentation.Name} guardada exitosamente. Asignado ID: {savedPresentation.Id}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la presentación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearFields();
                }
            }
        }
    }
}
