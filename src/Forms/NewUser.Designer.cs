namespace kiosko_ssms.Forms
{
    partial class NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.gbMain = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtNames = new Krypton.Toolkit.KryptonTextBox();
            this.txtSurnames = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.txtDni = new Krypton.Toolkit.KryptonTextBox();
            this.lbl99 = new Krypton.Toolkit.KryptonLabel();
            this.txtPhoneNumber = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.txtAddress = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.txtEmail = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.cbRole = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.btnClear = new Krypton.Toolkit.KryptonButton();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbMain.Panel)).BeginInit();
            this.gbMain.Panel.SuspendLayout();
            this.gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.Location = new System.Drawing.Point(12, 12);
            // 
            // gbMain.Panel
            // 
            this.gbMain.Panel.Controls.Add(this.kryptonLabel6);
            this.gbMain.Panel.Controls.Add(this.cbRole);
            this.gbMain.Panel.Controls.Add(this.txtEmail);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel5);
            this.gbMain.Panel.Controls.Add(this.txtAddress);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel4);
            this.gbMain.Panel.Controls.Add(this.txtPhoneNumber);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel3);
            this.gbMain.Panel.Controls.Add(this.txtDni);
            this.gbMain.Panel.Controls.Add(this.lbl99);
            this.gbMain.Panel.Controls.Add(this.txtSurnames);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel2);
            this.gbMain.Panel.Controls.Add(this.txtNames);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel1);
            this.gbMain.Size = new System.Drawing.Size(312, 532);
            this.gbMain.TabIndex = 0;
            this.gbMain.Values.Heading = "INFORMACIÓN DEL USUARIO";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(18, 20);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(67, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "NOMBRES";
            // 
            // txtNames
            // 
            this.txtNames.Location = new System.Drawing.Point(18, 46);
            this.txtNames.MaxLength = 50;
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(269, 23);
            this.txtNames.TabIndex = 1;
            // 
            // txtSurnames
            // 
            this.txtSurnames.Location = new System.Drawing.Point(18, 107);
            this.txtSurnames.MaxLength = 50;
            this.txtSurnames.Name = "txtSurnames";
            this.txtSurnames.Size = new System.Drawing.Size(269, 23);
            this.txtSurnames.TabIndex = 3;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(18, 81);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(71, 20);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "APELLIDOS";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(18, 171);
            this.txtDni.MaxLength = 50;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(269, 23);
            this.txtDni.TabIndex = 5;
            // 
            // lbl99
            // 
            this.lbl99.Location = new System.Drawing.Point(18, 145);
            this.lbl99.Name = "lbl99";
            this.lbl99.Size = new System.Drawing.Size(105, 20);
            this.lbl99.TabIndex = 4;
            this.lbl99.Values.Text = "DOC. IDENTIDAD";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(18, 233);
            this.txtPhoneNumber.MaxLength = 50;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(269, 23);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(18, 207);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel3.TabIndex = 6;
            this.kryptonLabel3.Values.Text = "TELÉFONO";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(18, 298);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(269, 71);
            this.txtAddress.TabIndex = 9;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(18, 272);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(73, 20);
            this.kryptonLabel4.TabIndex = 8;
            this.kryptonLabel4.Values.Text = "DIRECCIÓN";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(18, 410);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(269, 23);
            this.txtEmail.TabIndex = 11;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(18, 384);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(50, 20);
            this.kryptonLabel5.TabIndex = 10;
            this.kryptonLabel5.Values.Text = "E-MAIL";
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.DropDownWidth = 269;
            this.cbRole.Location = new System.Drawing.Point(18, 472);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(269, 22);
            this.cbRole.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbRole.TabIndex = 12;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(18, 445);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(33, 20);
            this.kryptonLabel6.TabIndex = 13;
            this.kryptonLabel6.Values.Text = "ROL";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(32, 567);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 25);
            this.btnClear.TabIndex = 1;
            this.btnClear.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnClear.Values.Text = "LIMPIAR";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(174, 567);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 25);
            this.btnSave.TabIndex = 2;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "GUARDAR";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 604);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "REGISTRO DE USUARIO";
            ((System.ComponentModel.ISupportInitialize)(this.gbMain.Panel)).EndInit();
            this.gbMain.Panel.ResumeLayout(false);
            this.gbMain.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbMain)).EndInit();
            this.gbMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox gbMain;
        private Krypton.Toolkit.KryptonTextBox txtEmail;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonTextBox txtAddress;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonTextBox txtPhoneNumber;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox txtDni;
        private Krypton.Toolkit.KryptonLabel lbl99;
        private Krypton.Toolkit.KryptonTextBox txtSurnames;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtNames;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonComboBox cbRole;
        private Krypton.Toolkit.KryptonButton btnClear;
        private Krypton.Toolkit.KryptonButton btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}