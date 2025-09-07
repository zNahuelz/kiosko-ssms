namespace kiosko_ssms.Forms
{
    partial class ProductDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetail));
            this.btnExit = new Krypton.Toolkit.KryptonButton();
            this.txtId = new Krypton.Toolkit.KryptonTextBox();
            this.txtName = new Krypton.Toolkit.KryptonTextBox();
            this.txtDescription = new Krypton.Toolkit.KryptonTextBox();
            this.txtBarcode = new Krypton.Toolkit.KryptonTextBox();
            this.txtBuyPrice = new Krypton.Toolkit.KryptonTextBox();
            this.txtSellPrice = new Krypton.Toolkit.KryptonTextBox();
            this.txtIsDeleted = new Krypton.Toolkit.KryptonTextBox();
            this.txtIsVisible = new Krypton.Toolkit.KryptonTextBox();
            this.txtUpdatedAt = new Krypton.Toolkit.KryptonTextBox();
            this.txtCreatedAt = new Krypton.Toolkit.KryptonTextBox();
            this.txtSupplier = new Krypton.Toolkit.KryptonTextBox();
            this.txtPresentation = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel12 = new Krypton.Toolkit.KryptonLabel();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tssLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(13, 522);
            this.btnExit.Name = "btnExit";
            this.btnExit.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleOrangeLightMode;
            this.btnExit.Size = new System.Drawing.Size(253, 36);
            this.btnExit.TabIndex = 1;
            this.btnExit.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnExit.Values.Text = "CERRAR";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(41, 12);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(224, 23);
            this.txtId.TabIndex = 2;
            this.txtId.Text = "kryptonTextBox1";
            this.txtId.DoubleClick += new System.EventHandler(this.txtId_DoubleClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 95);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(253, 61);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "kryptonTextBox2";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 190);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(253, 61);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.Text = "kryptonTextBox3";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(106, 40);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.ReadOnly = true;
            this.txtBarcode.Size = new System.Drawing.Size(159, 23);
            this.txtBarcode.TabIndex = 5;
            this.txtBarcode.Text = "kryptonTextBox4";
            this.txtBarcode.DoubleClick += new System.EventHandler(this.txtBarcode_DoubleClick);
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Location = new System.Drawing.Point(12, 279);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.ReadOnly = true;
            this.txtBuyPrice.Size = new System.Drawing.Size(121, 23);
            this.txtBuyPrice.TabIndex = 6;
            this.txtBuyPrice.Text = "kryptonTextBox5";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(139, 279);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.ReadOnly = true;
            this.txtSellPrice.Size = new System.Drawing.Size(126, 23);
            this.txtSellPrice.TabIndex = 7;
            this.txtSellPrice.Text = "kryptonTextBox6";
            // 
            // txtIsDeleted
            // 
            this.txtIsDeleted.Location = new System.Drawing.Point(139, 328);
            this.txtIsDeleted.Name = "txtIsDeleted";
            this.txtIsDeleted.ReadOnly = true;
            this.txtIsDeleted.Size = new System.Drawing.Size(126, 23);
            this.txtIsDeleted.TabIndex = 9;
            this.txtIsDeleted.Text = "kryptonTextBox7";
            // 
            // txtIsVisible
            // 
            this.txtIsVisible.Location = new System.Drawing.Point(12, 328);
            this.txtIsVisible.Name = "txtIsVisible";
            this.txtIsVisible.ReadOnly = true;
            this.txtIsVisible.Size = new System.Drawing.Size(121, 23);
            this.txtIsVisible.TabIndex = 8;
            this.txtIsVisible.Text = "kryptonTextBox8";
            // 
            // txtUpdatedAt
            // 
            this.txtUpdatedAt.Location = new System.Drawing.Point(139, 383);
            this.txtUpdatedAt.Name = "txtUpdatedAt";
            this.txtUpdatedAt.ReadOnly = true;
            this.txtUpdatedAt.Size = new System.Drawing.Size(126, 23);
            this.txtUpdatedAt.TabIndex = 11;
            this.txtUpdatedAt.Text = "kryptonTextBox9";
            // 
            // txtCreatedAt
            // 
            this.txtCreatedAt.Location = new System.Drawing.Point(12, 383);
            this.txtCreatedAt.Name = "txtCreatedAt";
            this.txtCreatedAt.ReadOnly = true;
            this.txtCreatedAt.Size = new System.Drawing.Size(121, 23);
            this.txtCreatedAt.TabIndex = 10;
            this.txtCreatedAt.Text = "kryptonTextBox10";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(12, 438);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(253, 23);
            this.txtSupplier.TabIndex = 12;
            this.txtSupplier.Text = "kryptonTextBox11";
            // 
            // txtPresentation
            // 
            this.txtPresentation.Location = new System.Drawing.Point(12, 493);
            this.txtPresentation.Name = "txtPresentation";
            this.txtPresentation.ReadOnly = true;
            this.txtPresentation.Size = new System.Drawing.Size(253, 23);
            this.txtPresentation.TabIndex = 13;
            this.txtPresentation.Text = "kryptonTextBox12";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(13, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(22, 20);
            this.kryptonLabel1.TabIndex = 14;
            this.kryptonLabel1.Values.Text = "ID";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(13, 41);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(87, 20);
            this.kryptonLabel2.TabIndex = 15;
            this.kryptonLabel2.Values.Text = "COD. BARRAS";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 69);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(61, 20);
            this.kryptonLabel3.TabIndex = 16;
            this.kryptonLabel3.Values.Text = "NOMBRE";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(12, 164);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(87, 20);
            this.kryptonLabel4.TabIndex = 17;
            this.kryptonLabel4.Values.Text = "DESCRIPCIÓN";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(12, 257);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(91, 20);
            this.kryptonLabel5.TabIndex = 18;
            this.kryptonLabel5.Values.Text = "PCO. COMPRA";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(139, 257);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(78, 20);
            this.kryptonLabel6.TabIndex = 19;
            this.kryptonLabel6.Values.Text = "PCO. VENTA";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(12, 308);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(76, 20);
            this.kryptonLabel7.TabIndex = 20;
            this.kryptonLabel7.Values.Text = "VISIBILIDAD";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(141, 308);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(56, 20);
            this.kryptonLabel8.TabIndex = 21;
            this.kryptonLabel8.Values.Text = "ESTADO";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(12, 357);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(109, 20);
            this.kryptonLabel9.TabIndex = 22;
            this.kryptonLabel9.Values.Text = "FECHA CREACIÓN";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(139, 357);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(124, 20);
            this.kryptonLabel10.TabIndex = 23;
            this.kryptonLabel10.Values.Text = "ULT. MODIFICACIÓN";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(12, 412);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(80, 20);
            this.kryptonLabel11.TabIndex = 24;
            this.kryptonLabel11.Values.Text = "PROVEEDOR";
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(12, 467);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(97, 20);
            this.kryptonLabel12.TabIndex = 25;
            this.kryptonLabel12.Values.Text = "PRESENTACIÓN";
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLabel});
            this.ssMain.Location = new System.Drawing.Point(0, 566);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(287, 22);
            this.ssMain.TabIndex = 26;
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
            // ProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 588);
            this.CloseBox = false;
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.kryptonLabel12);
            this.Controls.Add(this.kryptonLabel11);
            this.Controls.Add(this.kryptonLabel10);
            this.Controls.Add(this.kryptonLabel9);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.txtPresentation);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.txtUpdatedAt);
            this.Controls.Add(this.txtCreatedAt);
            this.Controls.Add(this.txtIsDeleted);
            this.Controls.Add(this.txtIsVisible);
            this.Controls.Add(this.txtSellPrice);
            this.Controls.Add(this.txtBuyPrice);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductDetail";
            this.Text = "DETALLE DE PRODUCTO";
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonButton btnExit;
        private Krypton.Toolkit.KryptonTextBox txtId;
        private Krypton.Toolkit.KryptonTextBox txtName;
        private Krypton.Toolkit.KryptonTextBox txtDescription;
        private Krypton.Toolkit.KryptonTextBox txtBarcode;
        private Krypton.Toolkit.KryptonTextBox txtBuyPrice;
        private Krypton.Toolkit.KryptonTextBox txtSellPrice;
        private Krypton.Toolkit.KryptonTextBox txtIsDeleted;
        private Krypton.Toolkit.KryptonTextBox txtIsVisible;
        private Krypton.Toolkit.KryptonTextBox txtUpdatedAt;
        private Krypton.Toolkit.KryptonTextBox txtCreatedAt;
        private Krypton.Toolkit.KryptonTextBox txtSupplier;
        private Krypton.Toolkit.KryptonTextBox txtPresentation;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tssLabel;
    }
}