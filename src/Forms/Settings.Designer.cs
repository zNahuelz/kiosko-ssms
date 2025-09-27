namespace kiosko_ssms.Forms
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.gbTaxes = new System.Windows.Forms.GroupBox();
            this.lblTaxesStatus = new System.Windows.Forms.Label();
            this.btnResetConfig = new System.Windows.Forms.Button();
            this.btnSaveTaxesConfig = new System.Windows.Forms.Button();
            this.chkTaxStatus = new System.Windows.Forms.CheckBox();
            this.nudTaxValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbWarning = new System.Windows.Forms.GroupBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.gbCurrency = new System.Windows.Forms.GroupBox();
            this.txtCurrencyShort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurrencyLong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResetCurrencyConfig = new System.Windows.Forms.Button();
            this.btnSaveCurrencyConfig = new System.Windows.Forms.Button();
            this.gbCompany = new System.Windows.Forms.GroupBox();
            this.txtTaxId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompanyAddress = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.btnSaveCompanyInfo = new System.Windows.Forms.Button();
            this.btnResetCompanyInfo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gbStartup = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbStartupTool = new System.Windows.Forms.ComboBox();
            this.btnSaveStartupTool = new System.Windows.Forms.Button();
            this.gbTaxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.gbWarning.SuspendLayout();
            this.gbCurrency.SuspendLayout();
            this.gbCompany.SuspendLayout();
            this.gbStartup.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTaxes
            // 
            this.gbTaxes.Controls.Add(this.lblTaxesStatus);
            this.gbTaxes.Controls.Add(this.btnResetConfig);
            this.gbTaxes.Controls.Add(this.btnSaveTaxesConfig);
            this.gbTaxes.Controls.Add(this.chkTaxStatus);
            this.gbTaxes.Controls.Add(this.nudTaxValue);
            this.gbTaxes.Controls.Add(this.label2);
            this.gbTaxes.Controls.Add(this.txtTaxName);
            this.gbTaxes.Controls.Add(this.label1);
            this.gbTaxes.Location = new System.Drawing.Point(12, 124);
            this.gbTaxes.Name = "gbTaxes";
            this.gbTaxes.Size = new System.Drawing.Size(294, 204);
            this.gbTaxes.TabIndex = 0;
            this.gbTaxes.TabStop = false;
            this.gbTaxes.Text = "CONFIGURACIÓN DE IMPUESTOS";
            // 
            // lblTaxesStatus
            // 
            this.lblTaxesStatus.AutoSize = true;
            this.lblTaxesStatus.Location = new System.Drawing.Point(187, 109);
            this.lblTaxesStatus.Name = "lblTaxesStatus";
            this.lblTaxesStatus.Size = new System.Drawing.Size(22, 13);
            this.lblTaxesStatus.TabIndex = 7;
            this.lblTaxesStatus.Text = "-----";
            // 
            // btnResetConfig
            // 
            this.btnResetConfig.Location = new System.Drawing.Point(43, 136);
            this.btnResetConfig.Name = "btnResetConfig";
            this.btnResetConfig.Size = new System.Drawing.Size(212, 23);
            this.btnResetConfig.TabIndex = 6;
            this.btnResetConfig.Text = "POR DEFECTO";
            this.btnResetConfig.UseVisualStyleBackColor = true;
            this.btnResetConfig.Click += new System.EventHandler(this.btnResetConfig_Click);
            // 
            // btnSaveTaxesConfig
            // 
            this.btnSaveTaxesConfig.Location = new System.Drawing.Point(43, 165);
            this.btnSaveTaxesConfig.Name = "btnSaveTaxesConfig";
            this.btnSaveTaxesConfig.Size = new System.Drawing.Size(212, 23);
            this.btnSaveTaxesConfig.TabIndex = 5;
            this.btnSaveTaxesConfig.Text = "GUARDAR";
            this.btnSaveTaxesConfig.UseVisualStyleBackColor = true;
            this.btnSaveTaxesConfig.Click += new System.EventHandler(this.btnSaveTaxesConfig_Click);
            // 
            // chkTaxStatus
            // 
            this.chkTaxStatus.AutoSize = true;
            this.chkTaxStatus.Location = new System.Drawing.Point(165, 108);
            this.chkTaxStatus.Name = "chkTaxStatus";
            this.chkTaxStatus.Size = new System.Drawing.Size(15, 14);
            this.chkTaxStatus.TabIndex = 4;
            this.chkTaxStatus.UseVisualStyleBackColor = true;
            this.chkTaxStatus.CheckedChanged += new System.EventHandler(this.chkTaxStatus_CheckedChanged);
            // 
            // nudTaxValue
            // 
            this.nudTaxValue.Location = new System.Drawing.Point(43, 107);
            this.nudTaxValue.Name = "nudTaxValue";
            this.nudTaxValue.Size = new System.Drawing.Size(93, 20);
            this.nudTaxValue.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "VALOR (EN %):";
            // 
            // txtTaxName
            // 
            this.txtTaxName.Location = new System.Drawing.Point(43, 44);
            this.txtTaxName.Name = "txtTaxName";
            this.txtTaxName.Size = new System.Drawing.Size(212, 20);
            this.txtTaxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE PARA MOSTRAR:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // gbWarning
            // 
            this.gbWarning.Controls.Add(this.lblWarning);
            this.gbWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWarning.ForeColor = System.Drawing.Color.Red;
            this.gbWarning.Location = new System.Drawing.Point(12, 12);
            this.gbWarning.Name = "gbWarning";
            this.gbWarning.Size = new System.Drawing.Size(596, 106);
            this.gbWarning.TabIndex = 1;
            this.gbWarning.TabStop = false;
            this.gbWarning.Text = "ADVERTENCIA";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Black;
            this.lblWarning.Location = new System.Drawing.Point(21, 35);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(559, 45);
            this.lblWarning.TabIndex = 0;
            this.lblWarning.Text = "Alterar la configuración del sistema puede conducir al mal funcionamiento del mis" +
    "mo.\r\nModifique la configuración siguiendo las instrucciones del manual de usuari" +
    "o del \r\nprograma cuando sea necesario.";
            // 
            // gbCurrency
            // 
            this.gbCurrency.Controls.Add(this.txtCurrencyShort);
            this.gbCurrency.Controls.Add(this.label4);
            this.gbCurrency.Controls.Add(this.txtCurrencyLong);
            this.gbCurrency.Controls.Add(this.label3);
            this.gbCurrency.Controls.Add(this.btnResetCurrencyConfig);
            this.gbCurrency.Controls.Add(this.btnSaveCurrencyConfig);
            this.gbCurrency.Location = new System.Drawing.Point(12, 334);
            this.gbCurrency.Name = "gbCurrency";
            this.gbCurrency.Size = new System.Drawing.Size(294, 172);
            this.gbCurrency.TabIndex = 2;
            this.gbCurrency.TabStop = false;
            this.gbCurrency.Text = "CONFIGURACIÓN MONETARIA";
            // 
            // txtCurrencyShort
            // 
            this.txtCurrencyShort.Location = new System.Drawing.Point(43, 79);
            this.txtCurrencyShort.MaxLength = 10;
            this.txtCurrencyShort.Name = "txtCurrencyShort";
            this.txtCurrencyShort.Size = new System.Drawing.Size(212, 20);
            this.txtCurrencyShort.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "NOMBRE CORTO";
            // 
            // txtCurrencyLong
            // 
            this.txtCurrencyLong.Location = new System.Drawing.Point(43, 38);
            this.txtCurrencyLong.MaxLength = 50;
            this.txtCurrencyLong.Name = "txtCurrencyLong";
            this.txtCurrencyLong.Size = new System.Drawing.Size(212, 20);
            this.txtCurrencyLong.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "NOMBRE LARGO";
            // 
            // btnResetCurrencyConfig
            // 
            this.btnResetCurrencyConfig.Location = new System.Drawing.Point(43, 105);
            this.btnResetCurrencyConfig.Name = "btnResetCurrencyConfig";
            this.btnResetCurrencyConfig.Size = new System.Drawing.Size(212, 23);
            this.btnResetCurrencyConfig.TabIndex = 9;
            this.btnResetCurrencyConfig.Text = "POR DEFECTO";
            this.btnResetCurrencyConfig.UseVisualStyleBackColor = true;
            this.btnResetCurrencyConfig.Click += new System.EventHandler(this.btnResetCurrencyConfig_Click);
            // 
            // btnSaveCurrencyConfig
            // 
            this.btnSaveCurrencyConfig.Location = new System.Drawing.Point(43, 134);
            this.btnSaveCurrencyConfig.Name = "btnSaveCurrencyConfig";
            this.btnSaveCurrencyConfig.Size = new System.Drawing.Size(212, 23);
            this.btnSaveCurrencyConfig.TabIndex = 8;
            this.btnSaveCurrencyConfig.Text = "GUARDAR";
            this.btnSaveCurrencyConfig.UseVisualStyleBackColor = true;
            this.btnSaveCurrencyConfig.Click += new System.EventHandler(this.btnSaveCurrencyConfig_Click);
            // 
            // gbCompany
            // 
            this.gbCompany.Controls.Add(this.txtTaxId);
            this.gbCompany.Controls.Add(this.label5);
            this.gbCompany.Controls.Add(this.txtCompanyAddress);
            this.gbCompany.Controls.Add(this.txtCompanyName);
            this.gbCompany.Controls.Add(this.lblCompanyAddress);
            this.gbCompany.Controls.Add(this.btnSaveCompanyInfo);
            this.gbCompany.Controls.Add(this.btnResetCompanyInfo);
            this.gbCompany.Controls.Add(this.label6);
            this.gbCompany.Location = new System.Drawing.Point(312, 124);
            this.gbCompany.Name = "gbCompany";
            this.gbCompany.Size = new System.Drawing.Size(296, 382);
            this.gbCompany.TabIndex = 3;
            this.gbCompany.TabStop = false;
            this.gbCompany.Text = "CONFIGURACIÓN EMPRESARIAL";
            // 
            // txtTaxId
            // 
            this.txtTaxId.Location = new System.Drawing.Point(39, 289);
            this.txtTaxId.MaxLength = 20;
            this.txtTaxId.Name = "txtTaxId";
            this.txtTaxId.Size = new System.Drawing.Size(212, 20);
            this.txtTaxId.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID/COD TRIBUTARIO";
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.Location = new System.Drawing.Point(39, 200);
            this.txtCompanyAddress.MaxLength = 150;
            this.txtCompanyAddress.Multiline = true;
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.Size = new System.Drawing.Size(212, 68);
            this.txtCompanyAddress.TabIndex = 17;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(39, 44);
            this.txtCompanyName.MaxLength = 150;
            this.txtCompanyName.Multiline = true;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(212, 115);
            this.txtCompanyName.TabIndex = 14;
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.AutoSize = true;
            this.lblCompanyAddress.Location = new System.Drawing.Point(36, 172);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.Size = new System.Drawing.Size(66, 13);
            this.lblCompanyAddress.TabIndex = 16;
            this.lblCompanyAddress.Text = "DIRECCIÓN";
            // 
            // btnSaveCompanyInfo
            // 
            this.btnSaveCompanyInfo.Location = new System.Drawing.Point(39, 344);
            this.btnSaveCompanyInfo.Name = "btnSaveCompanyInfo";
            this.btnSaveCompanyInfo.Size = new System.Drawing.Size(212, 23);
            this.btnSaveCompanyInfo.TabIndex = 13;
            this.btnSaveCompanyInfo.Text = "GUARDAR";
            this.btnSaveCompanyInfo.UseVisualStyleBackColor = true;
            this.btnSaveCompanyInfo.Click += new System.EventHandler(this.btnSaveCompanyInfo_Click);
            // 
            // btnResetCompanyInfo
            // 
            this.btnResetCompanyInfo.Location = new System.Drawing.Point(39, 315);
            this.btnResetCompanyInfo.Name = "btnResetCompanyInfo";
            this.btnResetCompanyInfo.Size = new System.Drawing.Size(212, 23);
            this.btnResetCompanyInfo.TabIndex = 15;
            this.btnResetCompanyInfo.Text = "POR DEFECTO";
            this.btnResetCompanyInfo.UseVisualStyleBackColor = true;
            this.btnResetCompanyInfo.Click += new System.EventHandler(this.btnResetCompanyInfo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "NOMBRE EMPRESA";
            // 
            // gbStartup
            // 
            this.gbStartup.Controls.Add(this.btnSaveStartupTool);
            this.gbStartup.Controls.Add(this.cbStartupTool);
            this.gbStartup.Controls.Add(this.label7);
            this.gbStartup.Location = new System.Drawing.Point(12, 512);
            this.gbStartup.Name = "gbStartup";
            this.gbStartup.Size = new System.Drawing.Size(596, 49);
            this.gbStartup.TabIndex = 4;
            this.gbStartup.TabStop = false;
            this.gbStartup.Text = "CONFIGURACIÓN DE INICIO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "HERRAMIENTA INICIAL:";
            // 
            // cbStartupTool
            // 
            this.cbStartupTool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStartupTool.FormattingEnabled = true;
            this.cbStartupTool.Location = new System.Drawing.Point(190, 17);
            this.cbStartupTool.Name = "cbStartupTool";
            this.cbStartupTool.Size = new System.Drawing.Size(212, 21);
            this.cbStartupTool.TabIndex = 9;
            // 
            // btnSaveStartupTool
            // 
            this.btnSaveStartupTool.Location = new System.Drawing.Point(408, 17);
            this.btnSaveStartupTool.Name = "btnSaveStartupTool";
            this.btnSaveStartupTool.Size = new System.Drawing.Size(143, 23);
            this.btnSaveStartupTool.TabIndex = 8;
            this.btnSaveStartupTool.Text = "GUARDAR";
            this.btnSaveStartupTool.UseVisualStyleBackColor = true;
            this.btnSaveStartupTool.Click += new System.EventHandler(this.btnSaveStartupForm_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 573);
            this.Controls.Add(this.gbStartup);
            this.Controls.Add(this.gbCompany);
            this.Controls.Add(this.gbCurrency);
            this.Controls.Add(this.gbWarning);
            this.Controls.Add(this.gbTaxes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CONFIGURACIÓN";
            this.gbTaxes.ResumeLayout(false);
            this.gbTaxes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.gbWarning.ResumeLayout(false);
            this.gbWarning.PerformLayout();
            this.gbCurrency.ResumeLayout(false);
            this.gbCurrency.PerformLayout();
            this.gbCompany.ResumeLayout(false);
            this.gbCompany.PerformLayout();
            this.gbStartup.ResumeLayout(false);
            this.gbStartup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTaxes;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtTaxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTaxValue;
        private System.Windows.Forms.CheckBox chkTaxStatus;
        private System.Windows.Forms.Button btnResetConfig;
        private System.Windows.Forms.Button btnSaveTaxesConfig;
        private System.Windows.Forms.GroupBox gbWarning;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblTaxesStatus;
        private System.Windows.Forms.GroupBox gbCurrency;
        private System.Windows.Forms.Button btnResetCurrencyConfig;
        private System.Windows.Forms.Button btnSaveCurrencyConfig;
        private System.Windows.Forms.TextBox txtCurrencyShort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrencyLong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbCompany;
        private System.Windows.Forms.TextBox txtCompanyAddress;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Button btnSaveCompanyInfo;
        private System.Windows.Forms.Button btnResetCompanyInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTaxId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCompanyAddress;
        private System.Windows.Forms.GroupBox gbStartup;
        private System.Windows.Forms.ComboBox cbStartupTool;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSaveStartupTool;
    }
}