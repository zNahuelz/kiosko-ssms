namespace kiosko_ssms.Forms
{
    partial class CustomerDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDetail));
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tssLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtUpdatedAt = new Krypton.Toolkit.KryptonTextBox();
            this.txtCreatedAt = new Krypton.Toolkit.KryptonTextBox();
            this.txtIsDeleted = new Krypton.Toolkit.KryptonTextBox();
            this.txtEmail = new Krypton.Toolkit.KryptonTextBox();
            this.txtPhoneNumber = new Krypton.Toolkit.KryptonTextBox();
            this.txtDni = new Krypton.Toolkit.KryptonTextBox();
            this.txtSurnames = new Krypton.Toolkit.KryptonTextBox();
            this.txtNames = new Krypton.Toolkit.KryptonTextBox();
            this.txtId = new Krypton.Toolkit.KryptonTextBox();
            this.btnExit = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.txtAddress = new Krypton.Toolkit.KryptonTextBox();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLabel});
            this.ssMain.Location = new System.Drawing.Point(0, 559);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(287, 22);
            this.ssMain.TabIndex = 52;
            this.ssMain.Text = "statusStrip1";
            // 
            // tssLabel
            // 
            this.tssLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssLabel.ForeColor = System.Drawing.Color.Teal;
            this.tssLabel.Name = "tssLabel";
            this.tssLabel.Size = new System.Drawing.Size(268, 17);
            this.tssLabel.Text = "Doble click para copiar ID/código de barras";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(141, 450);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(124, 20);
            this.kryptonLabel10.TabIndex = 49;
            this.kryptonLabel10.Values.Text = "ULT. MODIFICACIÓN";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(14, 450);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(109, 20);
            this.kryptonLabel9.TabIndex = 48;
            this.kryptonLabel9.Values.Text = "FECHA CREACIÓN";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(152, 259);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(56, 20);
            this.kryptonLabel8.TabIndex = 47;
            this.kryptonLabel8.Values.Text = "ESTADO";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(14, 389);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(50, 20);
            this.kryptonLabel7.TabIndex = 46;
            this.kryptonLabel7.Values.Text = "E-MAIL";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(13, 257);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel5.TabIndex = 44;
            this.kryptonLabel5.Values.Text = "TELÉFONO";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(13, 168);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(71, 20);
            this.kryptonLabel4.TabIndex = 43;
            this.kryptonLabel4.Values.Text = "APELLIDOS";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(13, 73);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(67, 20);
            this.kryptonLabel3.TabIndex = 42;
            this.kryptonLabel3.Values.Text = "NOMBRES";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(14, 45);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(32, 20);
            this.kryptonLabel2.TabIndex = 41;
            this.kryptonLabel2.Values.Text = "DNI";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(14, 17);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(22, 20);
            this.kryptonLabel1.TabIndex = 40;
            this.kryptonLabel1.Values.Text = "ID";
            // 
            // txtUpdatedAt
            // 
            this.txtUpdatedAt.Location = new System.Drawing.Point(141, 476);
            this.txtUpdatedAt.Name = "txtUpdatedAt";
            this.txtUpdatedAt.ReadOnly = true;
            this.txtUpdatedAt.Size = new System.Drawing.Size(126, 23);
            this.txtUpdatedAt.TabIndex = 37;
            this.txtUpdatedAt.Text = "kryptonTextBox9";
            // 
            // txtCreatedAt
            // 
            this.txtCreatedAt.Location = new System.Drawing.Point(14, 476);
            this.txtCreatedAt.Name = "txtCreatedAt";
            this.txtCreatedAt.ReadOnly = true;
            this.txtCreatedAt.Size = new System.Drawing.Size(121, 23);
            this.txtCreatedAt.TabIndex = 36;
            this.txtCreatedAt.Text = "kryptonTextBox10";
            // 
            // txtIsDeleted
            // 
            this.txtIsDeleted.Location = new System.Drawing.Point(150, 279);
            this.txtIsDeleted.Name = "txtIsDeleted";
            this.txtIsDeleted.ReadOnly = true;
            this.txtIsDeleted.Size = new System.Drawing.Size(117, 23);
            this.txtIsDeleted.TabIndex = 35;
            this.txtIsDeleted.Text = "kryptonTextBox7";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(14, 409);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(251, 23);
            this.txtEmail.TabIndex = 34;
            this.txtEmail.Text = "kryptonTextBox8";
            this.txtEmail.DoubleClick += new System.EventHandler(this.txtEmail_DoubleClick);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(13, 279);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(131, 23);
            this.txtPhoneNumber.TabIndex = 32;
            this.txtPhoneNumber.Text = "kryptonTextBox5";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(52, 44);
            this.txtDni.Name = "txtDni";
            this.txtDni.ReadOnly = true;
            this.txtDni.Size = new System.Drawing.Size(214, 23);
            this.txtDni.TabIndex = 31;
            this.txtDni.Text = "kryptonTextBox4";
            this.txtDni.DoubleClick += new System.EventHandler(this.txtDni_DoubleClick);
            // 
            // txtSurnames
            // 
            this.txtSurnames.Location = new System.Drawing.Point(13, 194);
            this.txtSurnames.Multiline = true;
            this.txtSurnames.Name = "txtSurnames";
            this.txtSurnames.ReadOnly = true;
            this.txtSurnames.Size = new System.Drawing.Size(253, 50);
            this.txtSurnames.TabIndex = 30;
            this.txtSurnames.Text = "kryptonTextBox3";
            // 
            // txtNames
            // 
            this.txtNames.Location = new System.Drawing.Point(13, 99);
            this.txtNames.Multiline = true;
            this.txtNames.Name = "txtNames";
            this.txtNames.ReadOnly = true;
            this.txtNames.Size = new System.Drawing.Size(253, 61);
            this.txtNames.TabIndex = 29;
            this.txtNames.Text = "kryptonTextBox2";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(52, 16);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(214, 23);
            this.txtId.TabIndex = 28;
            this.txtId.Text = "kryptonTextBox1";
            this.txtId.DoubleClick += new System.EventHandler(this.txtId_DoubleClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(13, 516);
            this.btnExit.Name = "btnExit";
            this.btnExit.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleOrangeLightMode;
            this.btnExit.Size = new System.Drawing.Size(253, 36);
            this.btnExit.TabIndex = 27;
            this.btnExit.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnExit.Values.Text = "CERRAR";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(14, 308);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(73, 20);
            this.kryptonLabel6.TabIndex = 54;
            this.kryptonLabel6.Values.Text = "DIRECCIÓN";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(14, 334);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(253, 45);
            this.txtAddress.TabIndex = 53;
            this.txtAddress.Text = "kryptonTextBox3";
            // 
            // CustomerDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 581);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.kryptonLabel10);
            this.Controls.Add(this.kryptonLabel9);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.txtUpdatedAt);
            this.Controls.Add(this.txtCreatedAt);
            this.Controls.Add(this.txtIsDeleted);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtSurnames);
            this.Controls.Add(this.txtNames);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerDetail";
            this.Text = "DETALLE DE CLIENTE";
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tssLabel;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtUpdatedAt;
        private Krypton.Toolkit.KryptonTextBox txtCreatedAt;
        private Krypton.Toolkit.KryptonTextBox txtIsDeleted;
        private Krypton.Toolkit.KryptonTextBox txtEmail;
        private Krypton.Toolkit.KryptonTextBox txtPhoneNumber;
        private Krypton.Toolkit.KryptonTextBox txtDni;
        private Krypton.Toolkit.KryptonTextBox txtSurnames;
        private Krypton.Toolkit.KryptonTextBox txtNames;
        private Krypton.Toolkit.KryptonTextBox txtId;
        private Krypton.Toolkit.KryptonButton btnExit;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonTextBox txtAddress;
    }
}