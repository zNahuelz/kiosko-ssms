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
            this.rbSalesGroup = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple5 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btnNewSale = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnSalesReport = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.rbProductsGroup = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btnProductsList = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnNewProduct = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnEditProduct = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.rbSuppliersGroup = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple2 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btnSuppliersList = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnNewSupplier = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnEditSupplier = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.rbCustomersGroup = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple4 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btnCustomerList = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnNewCustomer = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnEditCustomer = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.rbManagementGroup = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple3 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btnKillForms = new Krypton.Ribbon.KryptonRibbonGroupButton();
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
            this.mainRibbon.Size = new System.Drawing.Size(1285, 115);
            this.mainRibbon.TabIndex = 3;
            // 
            // mainTab
            // 
            this.mainTab.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.rbSalesGroup,
            this.rbProductsGroup,
            this.rbSuppliersGroup,
            this.rbCustomersGroup,
            this.rbManagementGroup});
            this.mainTab.Text = "INICIO";
            // 
            // rbSalesGroup
            // 
            this.rbSalesGroup.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple5});
            this.rbSalesGroup.TextLine1 = "VENTAS";
            // 
            // kryptonRibbonGroupTriple5
            // 
            this.kryptonRibbonGroupTriple5.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btnNewSale,
            this.btnSalesReport});
            // 
            // btnNewSale
            // 
            this.btnNewSale.ImageLarge = global::kiosko_ssms.Properties.Resources.usd;
            this.btnNewSale.ImageSmall = global::kiosko_ssms.Properties.Resources.usd;
            this.btnNewSale.TextLine1 = "NUEVA";
            this.btnNewSale.TextLine2 = "VENTA";
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.ImageLarge = global::kiosko_ssms.Properties.Resources.chart;
            this.btnSalesReport.ImageSmall = global::kiosko_ssms.Properties.Resources.chart;
            this.btnSalesReport.TextLine1 = "REPORTE";
            this.btnSalesReport.TextLine2 = "VENTAS";
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
            this.btnNewProduct,
            this.btnEditProduct});
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
            // btnEditProduct
            // 
            this.btnEditProduct.ImageLarge = global::kiosko_ssms.Properties.Resources.Windows_Journal;
            this.btnEditProduct.ImageSmall = global::kiosko_ssms.Properties.Resources.Windows_Journal;
            this.btnEditProduct.TextLine1 = "GESTIONAR";
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
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
            this.btnNewSupplier,
            this.btnEditSupplier});
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
            // btnEditSupplier
            // 
            this.btnEditSupplier.ImageLarge = global::kiosko_ssms.Properties.Resources.Fax_Received_Succesfully;
            this.btnEditSupplier.ImageSmall = global::kiosko_ssms.Properties.Resources.Fax_Received_Succesfully;
            this.btnEditSupplier.TextLine1 = "GESTIONAR";
            // 
            // rbCustomersGroup
            // 
            this.rbCustomersGroup.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple4});
            this.rbCustomersGroup.TextLine1 = "CLIENTES";
            // 
            // kryptonRibbonGroupTriple4
            // 
            this.kryptonRibbonGroupTriple4.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btnCustomerList,
            this.btnNewCustomer,
            this.btnEditCustomer});
            // 
            // btnCustomerList
            // 
            this.btnCustomerList.ImageLarge = global::kiosko_ssms.Properties.Resources.Address_BookXP;
            this.btnCustomerList.ImageSmall = global::kiosko_ssms.Properties.Resources.Address_BookXP;
            this.btnCustomerList.TextLine1 = "LISTADO";
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.ImageLarge = global::kiosko_ssms.Properties.Resources.Directory_Services;
            this.btnNewCustomer.ImageSmall = global::kiosko_ssms.Properties.Resources.Directory_Services;
            this.btnNewCustomer.TextLine1 = "NUEVO";
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.ImageLarge = global::kiosko_ssms.Properties.Resources.Fax_Sender_Information;
            this.btnEditCustomer.ImageSmall = global::kiosko_ssms.Properties.Resources.Fax_Sender_Information;
            this.btnEditCustomer.TextLine1 = "GESTIONAR";
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
            this.btnKillForms,
            this.btnExit});
            // 
            // btnKillForms
            // 
            this.btnKillForms.ImageLarge = global::kiosko_ssms.Properties.Resources.Pop_up_blocked;
            this.btnKillForms.ImageSmall = global::kiosko_ssms.Properties.Resources.Pop_up_blocked;
            this.btnKillForms.TextLine1 = "CERRAR";
            this.btnKillForms.TextLine2 = "FORMULARIOS";
            this.btnKillForms.Click += new System.EventHandler(this.btnKillForms_Click);
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
            this.ClientSize = new System.Drawing.Size(1285, 433);
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
        private Krypton.Ribbon.KryptonRibbonGroupButton btnEditProduct;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnEditSupplier;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnKillForms;
        private Krypton.Ribbon.KryptonRibbonGroup rbCustomersGroup;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple4;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnCustomerList;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnNewCustomer;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnEditCustomer;
        private Krypton.Ribbon.KryptonRibbonGroup rbSalesGroup;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple5;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnNewSale;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnSalesReport;
    }
}