using System;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class Settings : Form
    {
        private readonly string DefaultTaxName = "IGV";
        private readonly bool DefaultTaxesStatus = true;
        private readonly double DefaultTaxValue = 0.18;
        private readonly string DefaultCurrency = "S/.";
        private readonly string DefaultCurrencyName = "SOLES";
        private readonly string DefaultCompanyName = "Mi Empresa";
        private readonly string DefaultCompanyTaxId = "10001100221";
        private readonly string DefaultCompanyAddress = "Av. Principal 123, Ciudad";

        public Settings()
        {
            InitializeComponent();
            LoadTaxSettings();
            LoadCurrencySettings();
            LoadCompanySettings();
        }

        private void LoadTaxSettings()
        {
            txtTaxName.Text = Properties.Settings.Default.taxName;
            chkTaxStatus.Checked = Properties.Settings.Default.taxesStatus;
            nudTaxValue.Value = (Decimal)Properties.Settings.Default.taxValue * 100;
            HandleTaxesStatusLabel();
        }

        private void LoadCurrencySettings()
        {
            txtCurrencyLong.Text = Properties.Settings.Default.currencyLongName;
            txtCurrencyShort.Text = Properties.Settings.Default.currencyShortName;
        }

        private void LoadCompanySettings()
        {
            txtCompanyName.Text = Properties.Settings.Default.companyName;
            txtCompanyAddress.Text = Properties.Settings.Default.companyAddress;
            txtTaxId.Text = Properties.Settings.Default.companyTaxId;
        }

        private void HandleTaxesStatusLabel()
        {
            lblTaxesStatus.Text = chkTaxStatus.Checked ? "Habilitado" : "Deshabilitado";
        }

        private void LoadDefaultTaxSettings()
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cargar la configuración de impuestos predeterminada? El cambio será guardado automáticamente.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtTaxName.Text = DefaultTaxName;
                chkTaxStatus.Checked = DefaultTaxesStatus;
                nudTaxValue.Value = (Decimal)DefaultTaxValue * 100;
                UpdateTaxSettings();
            }
        }

        private void UpdateTaxSettings()
        {
            if (ValidateTaxesSettings())
            {
                DialogResult result = MessageBox.Show(
                $"¿Estás seguro de que deseas actualizar la configuración de impuestos? " +
                $"Se guardarán los siguientes valores:\n" +
                $"NOMBRE DE IMPUESTO: {txtTaxName.Text?.Trim().ToUpper()}\n" +
                $"VALOR (%): {nudTaxValue.Value}\n" +
                $"ESTADO: {(chkTaxStatus.Checked ? "HABILITADO" : "DESHABILITADO")}",
                "CONFIRMAR OPERACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Properties.Settings.Default.taxName = txtTaxName.Text?.Trim().ToUpper();
                    Properties.Settings.Default.taxValue = (double)(nudTaxValue.Value / 100);
                    Properties.Settings.Default.taxesStatus = chkTaxStatus.Checked;
                    Properties.Settings.Default.Save();
                    LoadTaxSettings();
                    MessageBox.Show("Configuración de impuestos actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void LoadDefaultCurrencySettings()
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cargar la configuración de moneda predeterminada? El cambio será guardado automáticamente.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtCurrencyLong.Text = DefaultCurrencyName;
                txtCurrencyShort.Text = DefaultCurrency;
                UpdateCurrencySettings();
            }
        }



        private void UpdateCurrencySettings()
        {
            if (ValidateCurrencySettings())
            {
                DialogResult result = MessageBox.Show(
                $"¿Estás seguro de que deseas actualizar la configuración de moneda? " +
                $"Se guardarán los siguientes valores:\n" +
                $"NOMBRE LARGO: {txtCurrencyLong.Text?.Trim().ToUpper()}\n" +
                $"NOMBRE CORTO: {txtCurrencyShort.Text?.Trim().ToUpper()}\n",
                "CONFIRMAR OPERACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Properties.Settings.Default.currencyLongName = txtCurrencyLong.Text?.Trim().ToUpper();
                    Properties.Settings.Default.currencyShortName = txtCurrencyShort.Text?.Trim().ToUpper();
                    Properties.Settings.Default.Save();
                    LoadCurrencySettings();
                    MessageBox.Show("Configuración de moneda actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void LoadDefaultCompanySettings()
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cargar la configuración de empresa predeterminada? El cambio será guardado automáticamente.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtCompanyName.Text = DefaultCompanyName;
                txtTaxId.Text = DefaultCompanyTaxId;
                txtCompanyAddress.Text = DefaultCompanyAddress;
                UpdateCompanySettings();
            }
        }

        private void UpdateCompanySettings()
        {
            if (ValidateCompanySettings())
            {
                DialogResult result = MessageBox.Show(
                $"¿Estás seguro de que deseas actualizar la configuración empresarial? " +
                $"Se guardarán los siguientes valores:\n" +
                $"NOMBRE EMPRESA: {txtCompanyName.Text?.Trim().ToUpper()}\n" +
                $"DIRECCIÓN: {txtCompanyAddress.Text?.Trim().ToUpper()}\n" +
                $"ID/COD TRIBUTARIO: {txtTaxId.Text?.Trim().ToUpper()}\n",
                "CONFIRMAR OPERACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Properties.Settings.Default.companyName = txtCompanyName.Text?.Trim().ToUpper();
                    Properties.Settings.Default.companyAddress = txtCompanyAddress.Text?.Trim().ToUpper();
                    Properties.Settings.Default.companyTaxId = txtTaxId.Text?.Trim().ToUpper();
                    Properties.Settings.Default.Save();
                    LoadCompanySettings();
                    MessageBox.Show("Configuración de empresa actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool ValidateTaxName()
        {
            string taxName = txtTaxName.Text?.Trim();
            if (string.IsNullOrEmpty(taxName))
            {
                errorProvider.SetError(txtTaxName, "El nombre del impuesto no puede estar vacío.");
                return false;
            }
            errorProvider.SetError(txtTaxName, "");
            return true;
        }

        private bool ValidateTaxValue()
        {
            decimal taxValue = nudTaxValue.Value;
            if (taxValue < 0 || taxValue > 100)
            {
                errorProvider.SetError(nudTaxValue, "El valor del impuesto debe estar entre 0% y 100%.");
                return false;
            }
            errorProvider.SetError(nudTaxValue, "");
            return true;
        }

        private bool ValidateTaxesSettings()
        {
            bool isTaxNameValid = ValidateTaxName();
            bool isTaxValueValid = ValidateTaxValue();
            return isTaxNameValid && isTaxValueValid;
        }

        private bool ValidateCurrencyShortName()
        {
            string currencyShort = txtCurrencyShort.Text?.Trim();
            if (string.IsNullOrEmpty(currencyShort))
            {
                errorProvider.SetError(txtCurrencyShort, "El nombre corto de la moneda no puede estar vacío.");
                return false;
            }
            errorProvider.SetError(txtCurrencyShort, "");
            return true;
        }

        private bool ValidateCurrencyLongName()
        {
            string currencyLong = txtCurrencyLong.Text?.Trim();
            if (string.IsNullOrEmpty(currencyLong))
            {
                errorProvider.SetError(txtCurrencyLong, "El nombre largo de la moneda no puede estar vacío.");
                return false;
            }
            errorProvider.SetError(txtCurrencyLong, "");
            return true;
        }

        private bool ValidateCurrencySettings()
        {
            bool isCurrencyShortValid = ValidateCurrencyShortName();
            bool isCurrencyLongValid = ValidateCurrencyLongName();
            return isCurrencyShortValid && isCurrencyLongValid;
        }

        private bool ValidateCompanyName()
        {
            string companyName = txtCompanyName.Text?.Trim();
            if (string.IsNullOrEmpty(companyName))
            {
                errorProvider.SetError(txtCompanyName, "El nombre de la empresa no puede estar vacío.");
                return false;
            }
            if (companyName.Length >= 150)
            {
                errorProvider.SetError(txtCompanyName, "El nombre de la empresa no puede tener más de 150 caracteres.");
                return false;
            }
            errorProvider.SetError(txtCompanyName, "");
            return true;
        }

        private bool ValidateCompanyAddress()
        {
            string companyAddress = txtCompanyAddress.Text?.Trim();
            if (string.IsNullOrEmpty(companyAddress))
            {
                errorProvider.SetError(txtCompanyAddress, "La dirección de la empresa no puede estar vacía.");
                return false;
            }
            if (companyAddress.Length >= 150)
            {
                errorProvider.SetError(txtCompanyAddress, "La dirección de la empresa no puede tener más de 150 caracteres.");
                return false;
            }
            errorProvider.SetError(txtCompanyAddress, "");
            return true;
        }

        private bool ValidateCompanyTaxId()
        {
            string taxId = txtTaxId.Text?.Trim();
            if (string.IsNullOrEmpty(taxId))
            {
                errorProvider.SetError(txtTaxId, "El ID/COD tributario de la empresa no puede estar vacío.");
                return false;
            }
            if (taxId.Length >= 20)
            {
                errorProvider.SetError(txtTaxId, "El ID/COD tributario de la empresa no puede tener más de 20 caracteres.");
                return false;
            }
            errorProvider.SetError(txtTaxId, "");
            return true;
        }

        private bool ValidateCompanySettings()
        {
            bool isCompanyNameValid = ValidateCompanyName();
            bool isCompanyAddressValid = ValidateCompanyAddress();
            bool isCompanyTaxIdValid = ValidateCompanyTaxId();
            return isCompanyNameValid && isCompanyAddressValid && isCompanyTaxIdValid;
        }

        private void chkTaxStatus_CheckedChanged(object sender, EventArgs e)
        {
            HandleTaxesStatusLabel();
        }

        private void btnResetConfig_Click(object sender, EventArgs e)
        {
            LoadDefaultTaxSettings();
        }

        private void btnResetCurrencyConfig_Click(object sender, EventArgs e)
        {
            LoadDefaultCurrencySettings();
        }

        private void btnResetCompanyInfo_Click(object sender, EventArgs e)
        {
            LoadDefaultCompanySettings();
        }


        private void btnSaveTaxesConfig_Click(object sender, EventArgs e)
        {
            UpdateTaxSettings();
        }

        private void btnSaveCurrencyConfig_Click(object sender, EventArgs e)
        {
            UpdateCurrencySettings();
        }

        private void btnSaveCompanyInfo_Click(object sender, EventArgs e)
        {
            UpdateCompanySettings();
        }
    }
}
