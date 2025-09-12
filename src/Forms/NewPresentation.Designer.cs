namespace kiosko_ssms.Forms
{
    partial class NewPresentation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPresentation));
            this.gbInfo = new Krypton.Toolkit.KryptonGroupBox();
            this.gbMain = new Krypton.Toolkit.KryptonGroupBox();
            this.nudQuantity = new Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.btnClear = new Krypton.Toolkit.KryptonButton();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.txtUnit = new Krypton.Toolkit.KryptonTextBox();
            this.txtName = new Krypton.Toolkit.KryptonTextBox();
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
            this.gbInfo.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.gbInfo.Size = new System.Drawing.Size(339, 115);
            this.gbInfo.TabIndex = 2;
            this.gbInfo.Values.Heading = "INFORMACIÓN";
            // 
            // gbMain
            // 
            this.gbMain.Location = new System.Drawing.Point(12, 139);
            this.gbMain.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            // 
            // gbMain.Panel
            // 
            this.gbMain.Panel.Controls.Add(this.nudQuantity);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel1);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel3);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel2);
            this.gbMain.Panel.Controls.Add(this.btnClear);
            this.gbMain.Panel.Controls.Add(this.btnSave);
            this.gbMain.Panel.Controls.Add(this.txtUnit);
            this.gbMain.Panel.Controls.Add(this.txtName);
            this.gbMain.Size = new System.Drawing.Size(339, 343);
            this.gbMain.TabIndex = 3;
            this.gbMain.Values.Heading = "INFORMACIÓN DE LA PRESENTACIÓN";
            // 
            // nudQuantity
            // 
            this.nudQuantity.AllowDecimals = true;
            this.nudQuantity.DecimalPlaces = 2;
            this.nudQuantity.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudQuantity.Location = new System.Drawing.Point(26, 112);
            this.nudQuantity.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(271, 22);
            this.nudQuantity.TabIndex = 17;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(26, 77);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(172, 20);
            this.kryptonLabel1.TabIndex = 16;
            this.kryptonLabel1.Values.Text = "CANTIDAD / VAL. NUMÉRICO";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(26, 140);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(120, 20);
            this.kryptonLabel3.TabIndex = 15;
            this.kryptonLabel3.Values.Text = "UNIDAD / AUXILIAR";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(26, 12);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(61, 20);
            this.kryptonLabel2.TabIndex = 14;
            this.kryptonLabel2.Values.Text = "NOMBRE";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(26, 258);
            this.btnClear.Name = "btnClear";
            this.btnClear.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurple;
            this.btnClear.Size = new System.Drawing.Size(271, 43);
            this.btnClear.TabIndex = 12;
            this.btnClear.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnClear.Values.Text = "LIMPIAR";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(26, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleOrangeLightMode;
            this.btnSave.Size = new System.Drawing.Size(271, 43);
            this.btnSave.TabIndex = 11;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "GUARDAR";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(26, 166);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(271, 23);
            this.txtUnit.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(26, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(271, 23);
            this.txtName.TabIndex = 1;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // NewPresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 490);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.gbInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPresentation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "REGISTRO DE PRESENTACIÓN";
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

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox gbInfo;
        private Krypton.Toolkit.KryptonGroupBox gbMain;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton btnClear;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonTextBox txtUnit;
        private Krypton.Toolkit.KryptonTextBox txtName;
        private Krypton.Toolkit.KryptonNumericUpDown nudQuantity;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}