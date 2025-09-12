namespace kiosko_ssms.Forms
{
    partial class EditPresentation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPresentation));
            this.gbMain = new Krypton.Toolkit.KryptonGroupBox();
            this.nudQuantity = new Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.btnReset = new Krypton.Toolkit.KryptonButton();
            this.btnUpdate = new Krypton.Toolkit.KryptonButton();
            this.txtUnit = new Krypton.Toolkit.KryptonTextBox();
            this.txtName = new Krypton.Toolkit.KryptonTextBox();
            this.gbInfo = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            this.btnSearch = new Krypton.Toolkit.KryptonButton();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkIsDeleted = new System.Windows.Forms.CheckBox();
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
            this.gbMain.Location = new System.Drawing.Point(16, 134);
            this.gbMain.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            // 
            // gbMain.Panel
            // 
            this.gbMain.Panel.Controls.Add(this.chkIsDeleted);
            this.gbMain.Panel.Controls.Add(this.nudQuantity);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel1);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel3);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel2);
            this.gbMain.Panel.Controls.Add(this.btnReset);
            this.gbMain.Panel.Controls.Add(this.btnUpdate);
            this.gbMain.Panel.Controls.Add(this.txtUnit);
            this.gbMain.Panel.Controls.Add(this.txtName);
            this.gbMain.Size = new System.Drawing.Size(339, 343);
            this.gbMain.TabIndex = 5;
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
            this.nudQuantity.Location = new System.Drawing.Point(26, 93);
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
            this.kryptonLabel1.Location = new System.Drawing.Point(26, 67);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(172, 20);
            this.kryptonLabel1.TabIndex = 16;
            this.kryptonLabel1.Values.Text = "CANTIDAD / VAL. NUMÉRICO";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(26, 124);
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
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(26, 258);
            this.btnReset.Name = "btnReset";
            this.btnReset.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurple;
            this.btnReset.Size = new System.Drawing.Size(271, 43);
            this.btnReset.TabIndex = 12;
            this.btnReset.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnReset.Values.Text = "REINICIAR";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(26, 209);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleOrangeLightMode;
            this.btnUpdate.Size = new System.Drawing.Size(271, 43);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnUpdate.Values.Text = "ACTUALIZAR";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(26, 150);
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
            // gbInfo
            // 
            this.gbInfo.Location = new System.Drawing.Point(16, 7);
            this.gbInfo.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            // 
            // gbInfo.Panel
            // 
            this.gbInfo.Panel.Controls.Add(this.kryptonLabel11);
            this.gbInfo.Panel.Controls.Add(this.btnSearch);
            this.gbInfo.Panel.Controls.Add(this.txtKeyword);
            this.gbInfo.Size = new System.Drawing.Size(339, 115);
            this.gbInfo.TabIndex = 4;
            this.gbInfo.Values.Heading = "BÚSQUEDA DE PRESENTACIÓN";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(75, 13);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(22, 20);
            this.kryptonLabel11.TabIndex = 32;
            this.kryptonLabel11.Values.Text = "ID";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(152, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.btnSearch.Size = new System.Drawing.Size(145, 38);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSearch.Values.Text = "BUSCAR";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyword.ForeColor = System.Drawing.Color.Red;
            this.txtKeyword.Location = new System.Drawing.Point(26, 39);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(120, 38);
            this.txtKeyword.TabIndex = 30;
            this.txtKeyword.DoubleClick += new System.EventHandler(this.txtKeyword_DoubleClick);
            this.txtKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyword_KeyPress);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // chkIsDeleted
            // 
            this.chkIsDeleted.AutoSize = true;
            this.chkIsDeleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.chkIsDeleted.Location = new System.Drawing.Point(26, 179);
            this.chkIsDeleted.Name = "chkIsDeleted";
            this.chkIsDeleted.Size = new System.Drawing.Size(85, 17);
            this.chkIsDeleted.TabIndex = 18;
            this.chkIsDeleted.Text = "ELIMINADO";
            this.chkIsDeleted.UseVisualStyleBackColor = false;
            // 
            // EditPresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 484);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.gbInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPresentation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GESTIÓN DE PRESENTACIÓN";
            this.Load += new System.EventHandler(this.EditPresentation_Load);
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
        private Krypton.Toolkit.KryptonNumericUpDown nudQuantity;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton btnReset;
        private Krypton.Toolkit.KryptonButton btnUpdate;
        private Krypton.Toolkit.KryptonTextBox txtUnit;
        private Krypton.Toolkit.KryptonTextBox txtName;
        private Krypton.Toolkit.KryptonGroupBox gbInfo;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox chkIsDeleted;
    }
}