namespace kiosko_ssms.Forms
{
    partial class EditSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSupplier));
            this.gbMain = new Krypton.Toolkit.KryptonGroupBox();
            this.txtEmail = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.txtPhoneNumber = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.txtAddress = new Krypton.Toolkit.KryptonTextBox();
            this.txtRuc = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.btnReset = new Krypton.Toolkit.KryptonButton();
            this.btnUpdate = new Krypton.Toolkit.KryptonButton();
            this.txtDescription = new Krypton.Toolkit.KryptonTextBox();
            this.txtName = new Krypton.Toolkit.KryptonTextBox();
            this.gbInfo = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            this.btnSearch = new Krypton.Toolkit.KryptonButton();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.chkIsDeleted = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbMain.Panel)).BeginInit();
            this.gbMain.Panel.SuspendLayout();
            this.gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbInfo.Panel)).BeginInit();
            this.gbInfo.Panel.SuspendLayout();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.Location = new System.Drawing.Point(12, 153);
            this.gbMain.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            // 
            // gbMain.Panel
            // 
            this.gbMain.Panel.Controls.Add(this.chkIsDeleted);
            this.gbMain.Panel.Controls.Add(this.txtEmail);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel6);
            this.gbMain.Panel.Controls.Add(this.txtPhoneNumber);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel5);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel4);
            this.gbMain.Panel.Controls.Add(this.txtAddress);
            this.gbMain.Panel.Controls.Add(this.txtRuc);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel1);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel3);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel2);
            this.gbMain.Panel.Controls.Add(this.btnReset);
            this.gbMain.Panel.Controls.Add(this.btnUpdate);
            this.gbMain.Panel.Controls.Add(this.txtDescription);
            this.gbMain.Panel.Controls.Add(this.txtName);
            this.gbMain.Size = new System.Drawing.Size(714, 452);
            this.gbMain.TabIndex = 4;
            this.gbMain.Values.Heading = "INFORMACIÓN DEL PROVEEDOR";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(365, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(312, 23);
            this.txtEmail.TabIndex = 23;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(365, 71);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(50, 20);
            this.kryptonLabel6.TabIndex = 22;
            this.kryptonLabel6.Values.Text = "E-MAIL";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(365, 38);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(312, 23);
            this.txtPhoneNumber.TabIndex = 21;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(365, 12);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel5.TabIndex = 20;
            this.kryptonLabel5.Values.Text = "TELÉFONO";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(26, 302);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(73, 20);
            this.kryptonLabel4.TabIndex = 19;
            this.kryptonLabel4.Values.Text = "DIRECCIÓN";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(26, 328);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(312, 82);
            this.txtAddress.TabIndex = 18;
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(26, 161);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(312, 23);
            this.txtRuc.TabIndex = 17;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(26, 135);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(34, 20);
            this.kryptonLabel1.TabIndex = 16;
            this.kryptonLabel1.Values.Text = "RUC";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(26, 185);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(87, 20);
            this.kryptonLabel3.TabIndex = 15;
            this.kryptonLabel3.Values.Text = "DESCRIPCIÓN";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(26, 12);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(61, 20);
            this.kryptonLabel2.TabIndex = 14;
            this.kryptonLabel2.Values.Text = "NOMBRE";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(388, 238);
            this.btnReset.Name = "btnReset";
            this.btnReset.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurple;
            this.btnReset.Size = new System.Drawing.Size(265, 43);
            this.btnReset.TabIndex = 12;
            this.btnReset.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnReset.Values.Text = "REINICIAR";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(388, 162);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleOrangeLightMode;
            this.btnUpdate.Size = new System.Drawing.Size(265, 43);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnUpdate.Values.Text = "ACTUALIZAR";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(26, 211);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(312, 82);
            this.txtDescription.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(26, 38);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(312, 82);
            this.txtName.TabIndex = 1;
            // 
            // gbInfo
            // 
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            // 
            // gbInfo.Panel
            // 
            this.gbInfo.Panel.Controls.Add(this.kryptonLabel11);
            this.gbInfo.Panel.Controls.Add(this.txtKeyword);
            this.gbInfo.Panel.Controls.Add(this.btnSearch);
            this.gbInfo.Size = new System.Drawing.Size(714, 135);
            this.gbInfo.TabIndex = 3;
            this.gbInfo.Values.Heading = "BUSQUEDA DE PROVEEDOR";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(165, 17);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(34, 20);
            this.kryptonLabel11.TabIndex = 32;
            this.kryptonLabel11.Values.Text = "RUC";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(388, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.btnSearch.Size = new System.Drawing.Size(265, 38);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSearch.Values.Text = "BUSCAR";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyword.ForeColor = System.Drawing.Color.Red;
            this.txtKeyword.Location = new System.Drawing.Point(26, 43);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(312, 38);
            this.txtKeyword.TabIndex = 30;
            this.txtKeyword.DoubleClick += new System.EventHandler(this.txtKeyword_DoubleClick);
            this.txtKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyword_KeyPress);
            // 
            // chkIsDeleted
            // 
            this.chkIsDeleted.AutoSize = true;
            this.chkIsDeleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.chkIsDeleted.Location = new System.Drawing.Point(365, 135);
            this.chkIsDeleted.Name = "chkIsDeleted";
            this.chkIsDeleted.Size = new System.Drawing.Size(85, 17);
            this.chkIsDeleted.TabIndex = 24;
            this.chkIsDeleted.Text = "ELIMINADO";
            this.chkIsDeleted.UseVisualStyleBackColor = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EditSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 617);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.gbInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GESTIÓN DE PROVEEDOR";
            ((System.ComponentModel.ISupportInitialize)(this.gbMain.Panel)).EndInit();
            this.gbMain.Panel.ResumeLayout(false);
            this.gbMain.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbMain)).EndInit();
            this.gbMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbInfo.Panel)).EndInit();
            this.gbInfo.Panel.ResumeLayout(false);
            this.gbInfo.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbInfo)).EndInit();
            this.gbInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox gbMain;
        private Krypton.Toolkit.KryptonTextBox txtEmail;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonTextBox txtPhoneNumber;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonTextBox txtAddress;
        private Krypton.Toolkit.KryptonTextBox txtRuc;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton btnReset;
        private Krypton.Toolkit.KryptonButton btnUpdate;
        private Krypton.Toolkit.KryptonTextBox txtDescription;
        private Krypton.Toolkit.KryptonTextBox txtName;
        private Krypton.Toolkit.KryptonGroupBox gbInfo;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private System.Windows.Forms.TextBox txtKeyword;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private System.Windows.Forms.CheckBox chkIsDeleted;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}