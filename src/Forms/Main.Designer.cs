namespace kiosko_ssms.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainRibbon = new Krypton.Ribbon.KryptonRibbon();
            this.mainTab = new Krypton.Ribbon.KryptonRibbonTab();
            this.rbProductsGroup = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btnProductsList = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnNewProduct = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.rbSuppliersGroup = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple2 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btnSuppliersList = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnNewSupplier = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.rbManagementGroup = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple3 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btnExit = new Krypton.Ribbon.KryptonRibbonGroupButton();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbon
            // 
            this.mainRibbon.Name = "mainRibbon";
            this.mainRibbon.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.mainRibbon.RibbonFileAppButton.AppButtonImage = global::kiosko_ssms.Properties.Resources.server_window;
            this.mainRibbon.RibbonTabs.AddRange(new Krypton.Ribbon.KryptonRibbonTab[] {
            this.mainTab});
            this.mainRibbon.SelectedTab = this.mainTab;
            this.mainRibbon.Size = new System.Drawing.Size(1153, 115);
            this.mainRibbon.TabIndex = 3;
            // 
            // mainTab
            // 
            this.mainTab.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.rbProductsGroup,
            this.rbSuppliersGroup,
            this.rbManagementGroup});
            this.mainTab.Text = "INICIO";
            // 
            // rbProductsGroup
            // 
            this.rbProductsGroup.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple1});
            this.rbProductsGroup.TextLine1 = "PRODUCTOS";
            // 
            // kryptonRibbonGroupTriple1
            // 
            this.kryptonRibbonGroupTriple1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btnProductsList,
            this.btnNewProduct});
            // 
            // btnProductsList
            // 
            this.btnProductsList.ImageLarge = global::kiosko_ssms.Properties.Resources.cylinder_database;
            this.btnProductsList.ImageSmall = global::kiosko_ssms.Properties.Resources.cylinder_database;
            this.btnProductsList.TextLine1 = "LISTADO";
            this.btnProductsList.Click += new System.EventHandler(this.btnProductsList_Click);
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.ImageLarge = global::kiosko_ssms.Properties.Resources.address_book_pad;
            this.btnNewProduct.ImageSmall = global::kiosko_ssms.Properties.Resources.address_book_pad;
            this.btnNewProduct.TextLine1 = "NUEVO";
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // rbSuppliersGroup
            // 
            this.rbSuppliersGroup.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple2});
            this.rbSuppliersGroup.TextLine1 = "PROVEEDORES";
            // 
            // kryptonRibbonGroupTriple2
            // 
            this.kryptonRibbonGroupTriple2.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btnSuppliersList,
            this.btnNewSupplier});
            // 
            // btnSuppliersList
            // 
            this.btnSuppliersList.ImageLarge = global::kiosko_ssms.Properties.Resources.address_book;
            this.btnSuppliersList.ImageSmall = global::kiosko_ssms.Properties.Resources.address_book;
            this.btnSuppliersList.TextLine1 = "LISTADO";
            // 
            // btnNewSupplier
            // 
            this.btnNewSupplier.ImageLarge = global::kiosko_ssms.Properties.Resources.address_book_pad_users;
            this.btnNewSupplier.ImageSmall = global::kiosko_ssms.Properties.Resources.address_book_pad_users;
            this.btnNewSupplier.TextLine1 = "NUEVO";
            // 
            // rbManagementGroup
            // 
            this.rbManagementGroup.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple3});
            this.rbManagementGroup.TextLine1 = "HERRAMIENTAS";
            // 
            // kryptonRibbonGroupTriple3
            // 
            this.kryptonRibbonGroupTriple3.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btnExit});
            // 
            // btnExit
            // 
            this.btnExit.ImageLarge = global::kiosko_ssms.Properties.Resources.msg_error;
            this.btnExit.ImageSmall = global::kiosko_ssms.Properties.Resources.msg_error;
            this.btnExit.TextLine1 = "SALIR";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kiosko_ssms.Properties.Resources.Setup1;
            this.ClientSize = new System.Drawing.Size(1153, 521);
            this.CloseBox = false;
            this.Controls.Add(this.mainRibbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KIOSKO v0.1 = SISTEMA SIMPLE DE GESTIÓN DE VENTAS";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Ribbon.KryptonRibbon mainRibbon;
        private Krypton.Ribbon.KryptonRibbonTab mainTab;
        private Krypton.Ribbon.KryptonRibbonGroup rbProductsGroup;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnProductsList;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnNewProduct;
        private Krypton.Ribbon.KryptonRibbonGroup rbSuppliersGroup;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple2;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnSuppliersList;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnNewSupplier;
        private Krypton.Ribbon.KryptonRibbonGroup rbManagementGroup;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple3;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnExit;
    }
}