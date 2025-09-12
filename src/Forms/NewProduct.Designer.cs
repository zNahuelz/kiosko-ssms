namespace kiosko_ssms.Forms
{
    partial class NewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProduct));
            this.gbInfo = new Krypton.Toolkit.KryptonGroupBox();
            this.gbMain = new Krypton.Toolkit.KryptonGroupBox();
            this.txtProfit = new Krypton.Toolkit.KryptonTextBox();
            this.nudStockMin = new Krypton.Toolkit.KryptonNumericUpDown();
            this.nudStock = new Krypton.Toolkit.KryptonNumericUpDown();
            this.nudSellPrice = new Krypton.Toolkit.KryptonNumericUpDown();
            this.nudBuyPrice = new Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.btnClear = new Krypton.Toolkit.KryptonButton();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.cbPresentation = new Krypton.Toolkit.KryptonComboBox();
            this.cbSupplier = new Krypton.Toolkit.KryptonComboBox();
            this.btnRandomBarcode = new Krypton.Toolkit.KryptonButton();
            this.txtDescription = new Krypton.Toolkit.KryptonTextBox();
            this.txtName = new Krypton.Toolkit.KryptonTextBox();
            this.txtBarcode = new Krypton.Toolkit.KryptonTextBox();
            this.statusStripMain = new Krypton.Toolkit.KryptonStatusStrip();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gbInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbInfo.Panel)).BeginInit();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbMain.Panel)).BeginInit();
            this.gbMain.Panel.SuspendLayout();
            this.gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPresentation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.gbInfo.Size = new System.Drawing.Size(695, 135);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.Values.Heading = "INFORMACIÓN";
            // 
            // gbMain
            // 
            this.gbMain.Location = new System.Drawing.Point(12, 153);
            this.gbMain.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            // 
            // gbMain.Panel
            // 
            this.gbMain.Panel.Controls.Add(this.txtProfit);
            this.gbMain.Panel.Controls.Add(this.nudStockMin);
            this.gbMain.Panel.Controls.Add(this.nudStock);
            this.gbMain.Panel.Controls.Add(this.nudSellPrice);
            this.gbMain.Panel.Controls.Add(this.nudBuyPrice);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel10);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel9);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel8);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel7);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel6);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel5);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel4);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel3);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel2);
            this.gbMain.Panel.Controls.Add(this.kryptonLabel1);
            this.gbMain.Panel.Controls.Add(this.btnClear);
            this.gbMain.Panel.Controls.Add(this.btnSave);
            this.gbMain.Panel.Controls.Add(this.cbPresentation);
            this.gbMain.Panel.Controls.Add(this.cbSupplier);
            this.gbMain.Panel.Controls.Add(this.btnRandomBarcode);
            this.gbMain.Panel.Controls.Add(this.txtDescription);
            this.gbMain.Panel.Controls.Add(this.txtName);
            this.gbMain.Panel.Controls.Add(this.txtBarcode);
            this.gbMain.Size = new System.Drawing.Size(695, 452);
            this.gbMain.TabIndex = 1;
            this.gbMain.Values.Heading = "INFORMACIÓN DEL PRODUCTO";
            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(244, 327);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.ReadOnly = true;
            this.txtProfit.Size = new System.Drawing.Size(76, 23);
            this.txtProfit.TabIndex = 28;
            this.txtProfit.Text = "---";
            // 
            // nudStockMin
            // 
            this.nudStockMin.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudStockMin.Location = new System.Drawing.Point(183, 381);
            this.nudStockMin.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudStockMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStockMin.Name = "nudStockMin";
            this.nudStockMin.Size = new System.Drawing.Size(137, 22);
            this.nudStockMin.TabIndex = 27;
            this.nudStockMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudStock
            // 
            this.nudStock.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudStock.Location = new System.Drawing.Point(26, 381);
            this.nudStock.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudStock.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(123, 22);
            this.nudStock.TabIndex = 26;
            this.nudStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudSellPrice
            // 
            this.nudSellPrice.AllowDecimals = true;
            this.nudSellPrice.DecimalPlaces = 2;
            this.nudSellPrice.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSellPrice.Location = new System.Drawing.Point(142, 327);
            this.nudSellPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSellPrice.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudSellPrice.Name = "nudSellPrice";
            this.nudSellPrice.Size = new System.Drawing.Size(78, 22);
            this.nudSellPrice.TabIndex = 24;
            this.nudSellPrice.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudSellPrice.ValueChanged += new System.EventHandler(this.nudSellPrice_ValueChanged);
            // 
            // nudBuyPrice
            // 
            this.nudBuyPrice.AllowDecimals = true;
            this.nudBuyPrice.DecimalPlaces = 2;
            this.nudBuyPrice.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudBuyPrice.Location = new System.Drawing.Point(26, 327);
            this.nudBuyPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudBuyPrice.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudBuyPrice.Name = "nudBuyPrice";
            this.nudBuyPrice.Size = new System.Drawing.Size(87, 22);
            this.nudBuyPrice.TabIndex = 23;
            this.nudBuyPrice.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudBuyPrice.ValueChanged += new System.EventHandler(this.nudBuyPrice_ValueChanged);
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(183, 355);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(98, 20);
            this.kryptonLabel10.TabIndex = 22;
            this.kryptonLabel10.Values.Text = "STOCK MINIMO";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(26, 355);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel9.TabIndex = 21;
            this.kryptonLabel9.Values.Text = "STOCK";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(248, 300);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel8.TabIndex = 20;
            this.kryptonLabel8.Values.Text = "GANANCIA";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(142, 300);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(78, 20);
            this.kryptonLabel7.TabIndex = 19;
            this.kryptonLabel7.Values.Text = "PCO. VENTA";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(26, 300);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(91, 20);
            this.kryptonLabel6.TabIndex = 18;
            this.kryptonLabel6.Values.Text = "PCO. COMPRA";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(388, 70);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(97, 20);
            this.kryptonLabel5.TabIndex = 17;
            this.kryptonLabel5.Values.Text = "PRESENTACIÓN";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(388, 12);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(80, 20);
            this.kryptonLabel4.TabIndex = 16;
            this.kryptonLabel4.Values.Text = "PROVEEDOR";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(26, 186);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(87, 20);
            this.kryptonLabel3.TabIndex = 15;
            this.kryptonLabel3.Values.Text = "DESCRIPCIÓN";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(26, 71);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(61, 20);
            this.kryptonLabel2.TabIndex = 14;
            this.kryptonLabel2.Values.Text = "NOMBRE";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(26, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(123, 20);
            this.kryptonLabel1.TabIndex = 13;
            this.kryptonLabel1.Values.Text = "CÓDIGO DE BARRAS";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(388, 211);
            this.btnClear.Name = "btnClear";
            this.btnClear.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurple;
            this.btnClear.Size = new System.Drawing.Size(265, 43);
            this.btnClear.TabIndex = 12;
            this.btnClear.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnClear.Values.Text = "LIMPIAR";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(388, 135);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleOrangeLightMode;
            this.btnSave.Size = new System.Drawing.Size(265, 43);
            this.btnSave.TabIndex = 11;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "GUARDAR";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbPresentation
            // 
            this.cbPresentation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPresentation.DropDownWidth = 265;
            this.cbPresentation.Location = new System.Drawing.Point(388, 96);
            this.cbPresentation.Name = "cbPresentation";
            this.cbPresentation.Size = new System.Drawing.Size(265, 22);
            this.cbPresentation.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbPresentation.TabIndex = 10;
            // 
            // cbSupplier
            // 
            this.cbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplier.DropDownWidth = 265;
            this.cbSupplier.Location = new System.Drawing.Point(388, 38);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(265, 22);
            this.cbSupplier.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbSupplier.TabIndex = 9;
            // 
            // btnRandomBarcode
            // 
            this.btnRandomBarcode.Location = new System.Drawing.Point(248, 38);
            this.btnRandomBarcode.Name = "btnRandomBarcode";
            this.btnRandomBarcode.Size = new System.Drawing.Size(90, 25);
            this.btnRandomBarcode.TabIndex = 4;
            this.btnRandomBarcode.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRandomBarcode.Values.Text = "ALEATORIO";
            this.btnRandomBarcode.Click += new System.EventHandler(this.btnRandomBarcode_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(26, 212);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(312, 82);
            this.txtDescription.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(26, 97);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(312, 82);
            this.txtName.TabIndex = 1;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(26, 39);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(194, 23);
            this.txtBarcode.TabIndex = 0;
            // 
            // statusStripMain
            // 
            this.statusStripMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStripMain.Location = new System.Drawing.Point(0, 619);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.ProgressBars = null;
            this.statusStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStripMain.Size = new System.Drawing.Size(722, 22);
            this.statusStripMain.TabIndex = 2;
            this.statusStripMain.Text = "kryptonStatusStrip1";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 641);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.gbInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "REGISTRO DE PRODUCTO";
            this.Load += new System.EventHandler(this.NewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbInfo.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbInfo)).EndInit();
            this.gbInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbMain.Panel)).EndInit();
            this.gbMain.Panel.ResumeLayout(false);
            this.gbMain.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbMain)).EndInit();
            this.gbMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbPresentation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox gbInfo;
        private Krypton.Toolkit.KryptonGroupBox gbMain;
        private Krypton.Toolkit.KryptonTextBox txtBarcode;
        private Krypton.Toolkit.KryptonTextBox txtDescription;
        private Krypton.Toolkit.KryptonTextBox txtName;
        private Krypton.Toolkit.KryptonButton btnRandomBarcode;
        private Krypton.Toolkit.KryptonStatusStrip statusStripMain;
        private Krypton.Toolkit.KryptonComboBox cbPresentation;
        private Krypton.Toolkit.KryptonComboBox cbSupplier;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnClear;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonNumericUpDown nudSellPrice;
        private Krypton.Toolkit.KryptonNumericUpDown nudBuyPrice;
        private Krypton.Toolkit.KryptonNumericUpDown nudStockMin;
        private Krypton.Toolkit.KryptonNumericUpDown nudStock;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Krypton.Toolkit.KryptonTextBox txtProfit;
    }
}