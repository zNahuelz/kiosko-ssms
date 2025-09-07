namespace kiosko_ssms.Forms
{
    partial class NewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCustomer));
            this.gbInfo = new Krypton.Toolkit.KryptonGroupBox();
            this.gbMain = new Krypton.Toolkit.KryptonGroupBox();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnClear = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.txtAddress = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.txtPhoneNumber = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.txtDni = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.txtSurnames = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.txtNames = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtEmail = new Krypton.Toolkit.KryptonTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gbInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbInfo.Panel)).BeginInit();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbMain.Panel)).BeginInit();
            this.gbMain.Panel.SuspendLayout();
            this.gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.Size = new System.Drawing.Size(430, 115);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.Values.Heading = "INFORMACIÓN";
            // 
            // gbMain
            // 
            this.gbMain.Location = new System.Drawing.Point(12, 133);
            this.gbMain.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            // 
            // gbMain.Panel
            // 
            this.gbMain.Panel.Controls.Add(this.btnSave);
            this.gbMain.Panel.Controls.Add(this.btnClear);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel6);
            this.gbMain.Panel.Controls.Add(this.txtAddress);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel5);
            this.gbMain.Panel.Controls.Add(this.txtPhoneNumber);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel4);
            this.gbMain.Panel.Controls.Add(this.txtDni);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel3);
            this.gbMain.Panel.Controls.Add(this.txtSurnames);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel2);
            this.gbMain.Panel.Controls.Add(this.txtNames);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel1);
            this.gbMain.Size = new System.Drawing.Size(430, 483);
            this.gbMain.TabIndex = 1;
            this.gbMain.Values.Heading = "INFORMACIÓN DEL CLIENTE";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(216, 416);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.btnSave.Size = new System.Drawing.Size(170, 34);
            this.btnSave.TabIndex = 26;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "GUARDAR";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(27, 416);
            this.btnClear.Name = "btnClear";
            this.btnClear.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurple;
            this.btnClear.Size = new System.Drawing.Size(169, 34);
            this.btnClear.TabIndex = 25;
            this.btnClear.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnClear.Values.Text = "LIMPIAR";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(27, 353);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(50, 20);
            this.kryptonLabel6.TabIndex = 24;
            this.kryptonLabel6.Values.Text = "E-MAIL";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(27, 291);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(359, 55);
            this.txtAddress.TabIndex = 23;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(27, 265);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(73, 20);
            this.kryptonLabel5.TabIndex = 22;
            this.kryptonLabel5.Values.Text = "DIRECCIÓN";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(27, 231);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(359, 23);
            this.txtPhoneNumber.TabIndex = 21;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(27, 205);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel4.TabIndex = 20;
            this.kryptonLabel4.Values.Text = "TELÉFONO";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(27, 169);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(359, 23);
            this.txtDni.TabIndex = 19;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(27, 143);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(32, 20);
            this.kryptonLabel3.TabIndex = 18;
            this.kryptonLabel3.Values.Text = "DNI";
            // 
            // txtSurnames
            // 
            this.txtSurnames.Location = new System.Drawing.Point(27, 107);
            this.txtSurnames.Name = "txtSurnames";
            this.txtSurnames.Size = new System.Drawing.Size(359, 23);
            this.txtSurnames.TabIndex = 17;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(27, 81);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(71, 20);
            this.kryptonLabel2.TabIndex = 16;
            this.kryptonLabel2.Values.Text = "APELLIDOS";
            // 
            // txtNames
            // 
            this.txtNames.Location = new System.Drawing.Point(27, 44);
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(359, 23);
            this.txtNames.TabIndex = 15;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(27, 18);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(67, 20);
            this.kryptonLabel1.TabIndex = 14;
            this.kryptonLabel1.Values.Text = "NOMBRES";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(41, 534);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(359, 23);
            this.txtEmail.TabIndex = 25;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 622);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.gbInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCustomer";
            this.Text = "REGISTRO DE CLIENTE";
            ((System.ComponentModel.ISupportInitialize)(this.gbInfo.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbInfo)).EndInit();
            this.gbInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbMain.Panel)).EndInit();
            this.gbMain.Panel.ResumeLayout(false);
            this.gbMain.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbMain)).EndInit();
            this.gbMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox gbInfo;
        private Krypton.Toolkit.KryptonGroupBox gbMain;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtNames;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonTextBox txtAddress;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonTextBox txtPhoneNumber;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonTextBox txtDni;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox txtSurnames;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtEmail;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnClear;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}