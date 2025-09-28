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
            this.components = new System.ComponentModel.Container();
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
            this.rbPresentationsGroup = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupLines1 = new Krypton.Ribbon.KryptonRibbonGroupLines();
            this.btnPresentationList = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnNewPresentation = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnEditPresentation = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.rbVouchersGroup = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupLines2 = new Krypton.Ribbon.KryptonRibbonGroupLines();
            this.btnVoucherList = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.rbManagementGroup = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple3 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btnKillForms = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnExit = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.moreTab = new Krypton.Ribbon.KryptonRibbonTab();
            this.rbPaymentTypesGroup = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple7 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btnPaymentTypeList = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnManagePaymentType = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.rbVoucherTypesGroup = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple8 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btnVoucherTypeList = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnNewVoucherType = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnManageVoucherTypes = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.helpTab = new Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple6 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btnSettings = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnAbout = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.ssMain = new Krypton.Toolkit.KryptonStatusStrip();
            this.tssDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssClock = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).BeginInit();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainRibbon
            // 
            this.mainRibbon.Name = "mainRibbon";
            this.mainRibbon.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.mainRibbon.RibbonFileAppButton.AppButtonImage = global::kiosko_ssms.Properties.Resources.server_window;
            this.mainRibbon.RibbonTabs.AddRange(new Krypton.Ribbon.KryptonRibbonTab[] {
            this.mainTab,
            this.moreTab,
            this.helpTab});
            this.mainRibbon.SelectedTab = this.mainTab;
            this.mainRibbon.Size = new System.Drawing.Size(1669, 115);
            this.mainRibbon.TabIndex = 3;
            // 
            // mainTab
            // 
            this.mainTab.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.rbSalesGroup,
            this.rbProductsGroup,
            this.rbSuppliersGroup,
            this.rbCustomersGroup,
            this.rbPresentationsGroup,
            this.rbVouchersGroup,
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
            this.btnNewSale.Click += new System.EventHandler(this.btnNewSale_Click);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.ImageLarge = global::kiosko_ssms.Properties.Resources.chart;
            this.btnSalesReport.ImageSmall = global::kiosko_ssms.Properties.Resources.chart;
            this.btnSalesReport.TextLine1 = "REPORTE";
            this.btnSalesReport.TextLine2 = "VENTAS";
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
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
            this.btnSuppliersList.Click += new System.EventHandler(this.btnSuppliersList_Click);
            // 
            // btnNewSupplier
            // 
            this.btnNewSupplier.ImageLarge = global::kiosko_ssms.Properties.Resources.address_book_pad_users;
            this.btnNewSupplier.ImageSmall = global::kiosko_ssms.Properties.Resources.address_book_pad_users;
            this.btnNewSupplier.TextLine1 = "NUEVO";
            this.btnNewSupplier.Click += new System.EventHandler(this.btnNewSupplier_Click);
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.ImageLarge = global::kiosko_ssms.Properties.Resources.Fax_Received_Succesfully;
            this.btnEditSupplier.ImageSmall = global::kiosko_ssms.Properties.Resources.Fax_Received_Succesfully;
            this.btnEditSupplier.TextLine1 = "GESTIONAR";
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
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
            this.btnCustomerList.Click += new System.EventHandler(this.btnCustomerList_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.ImageLarge = global::kiosko_ssms.Properties.Resources.Directory_Services;
            this.btnNewCustomer.ImageSmall = global::kiosko_ssms.Properties.Resources.Directory_Services;
            this.btnNewCustomer.TextLine1 = "NUEVO";
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.ImageLarge = global::kiosko_ssms.Properties.Resources.Fax_Sender_Information;
            this.btnEditCustomer.ImageSmall = global::kiosko_ssms.Properties.Resources.Fax_Sender_Information;
            this.btnEditCustomer.TextLine1 = "GESTIONAR";
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // rbPresentationsGroup
            // 
            this.rbPresentationsGroup.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupLines1});
            this.rbPresentationsGroup.TextLine1 = "PRESENTACIONES";
            // 
            // kryptonRibbonGroupLines1
            // 
            this.kryptonRibbonGroupLines1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btnPresentationList,
            this.btnNewPresentation,
            this.btnEditPresentation});
            // 
            // btnPresentationList
            // 
            this.btnPresentationList.ImageLarge = global::kiosko_ssms.Properties.Resources.appwizard_list;
            this.btnPresentationList.ImageSmall = global::kiosko_ssms.Properties.Resources.appwizard_list;
            this.btnPresentationList.TextLine1 = "LISTADO";
            this.btnPresentationList.Click += new System.EventHandler(this.btnPresentationList_Click);
            // 
            // btnNewPresentation
            // 
            this.btnNewPresentation.ImageLarge = global::kiosko_ssms.Properties.Resources.catalog_1;
            this.btnNewPresentation.ImageSmall = global::kiosko_ssms.Properties.Resources.catalog_1;
            this.btnNewPresentation.TextLine1 = "NUEVA";
            this.btnNewPresentation.Click += new System.EventHandler(this.btnNewPresentation_Click);
            // 
            // btnEditPresentation
            // 
            this.btnEditPresentation.ImageLarge = global::kiosko_ssms.Properties.Resources.notepad_file_gear_2;
            this.btnEditPresentation.ImageSmall = global::kiosko_ssms.Properties.Resources.notepad_file_gear_2;
            this.btnEditPresentation.TextLine1 = "GESTIONAR";
            this.btnEditPresentation.Click += new System.EventHandler(this.btnEditPresentation_Click);
            // 
            // rbVouchersGroup
            // 
            this.rbVouchersGroup.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupLines2});
            this.rbVouchersGroup.TextLine1 = "BOLETAS-FACTURAS";
            // 
            // kryptonRibbonGroupLines2
            // 
            this.kryptonRibbonGroupLines2.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btnVoucherList});
            // 
            // btnVoucherList
            // 
            this.btnVoucherList.ImageLarge = global::kiosko_ssms.Properties.Resources.search_directory_0;
            this.btnVoucherList.ImageSmall = global::kiosko_ssms.Properties.Resources.search_directory_0;
            this.btnVoucherList.TextLine1 = "LISTADO";
            this.btnVoucherList.Click += new System.EventHandler(this.btnVoucherList_Click);
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
            // moreTab
            // 
            this.moreTab.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.rbPaymentTypesGroup,
            this.rbVoucherTypesGroup});
            this.moreTab.Text = "OTROS";
            // 
            // rbPaymentTypesGroup
            // 
            this.rbPaymentTypesGroup.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple7});
            this.rbPaymentTypesGroup.TextLine1 = "TIPO DE PAGOS";
            // 
            // kryptonRibbonGroupTriple7
            // 
            this.kryptonRibbonGroupTriple7.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btnPaymentTypeList,
            this.btnManagePaymentType});
            // 
            // btnPaymentTypeList
            // 
            this.btnPaymentTypeList.ImageLarge = global::kiosko_ssms.Properties.Resources.cardfile_1;
            this.btnPaymentTypeList.ImageSmall = global::kiosko_ssms.Properties.Resources.cardfile_1;
            this.btnPaymentTypeList.TextLine1 = "LISTADO";
            this.btnPaymentTypeList.Click += new System.EventHandler(this.btnPaymentTypeList_Click);
            // 
            // btnManagePaymentType
            // 
            this.btnManagePaymentType.ImageLarge = global::kiosko_ssms.Properties.Resources.address_book_card_copy_0;
            this.btnManagePaymentType.ImageSmall = global::kiosko_ssms.Properties.Resources.address_book_card_copy_0;
            this.btnManagePaymentType.TextLine1 = "GESTIONAR";
            this.btnManagePaymentType.Click += new System.EventHandler(this.btnManagePaymentType_Click);
            // 
            // rbVoucherTypesGroup
            // 
            this.rbVoucherTypesGroup.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple8});
            this.rbVoucherTypesGroup.TextLine1 = "TIPO DE COMPS.";
            // 
            // kryptonRibbonGroupTriple8
            // 
            this.kryptonRibbonGroupTriple8.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btnVoucherTypeList,
            this.btnNewVoucherType,
            this.btnManageVoucherTypes});
            // 
            // btnVoucherTypeList
            // 
            this.btnVoucherTypeList.ImageLarge = global::kiosko_ssms.Properties.Resources.window_red_hilights;
            this.btnVoucherTypeList.ImageSmall = global::kiosko_ssms.Properties.Resources.window_red_hilights;
            this.btnVoucherTypeList.TextLine1 = "LISTADO";
            this.btnVoucherTypeList.Click += new System.EventHandler(this.btnVoucherTypeList_Click);
            // 
            // btnNewVoucherType
            // 
            this.btnNewVoucherType.ImageLarge = global::kiosko_ssms.Properties.Resources.write_red;
            this.btnNewVoucherType.ImageSmall = global::kiosko_ssms.Properties.Resources.write_red;
            this.btnNewVoucherType.TextLine1 = "NUEVO";
            this.btnNewVoucherType.Click += new System.EventHandler(this.btnNewVoucherType_Click);
            // 
            // btnManageVoucherTypes
            // 
            this.btnManageVoucherTypes.ImageLarge = global::kiosko_ssms.Properties.Resources.windows_three;
            this.btnManageVoucherTypes.ImageSmall = global::kiosko_ssms.Properties.Resources.windows_three;
            this.btnManageVoucherTypes.TextLine1 = "GESTIONAR";
            this.btnManageVoucherTypes.Click += new System.EventHandler(this.btnManageVoucherTypes_Click);
            // 
            // helpTab
            // 
            this.helpTab.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1});
            this.helpTab.Text = "AYUDA";
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple6});
            this.kryptonRibbonGroup1.TextLine1 = "INFO.";
            // 
            // kryptonRibbonGroupTriple6
            // 
            this.kryptonRibbonGroupTriple6.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btnSettings,
            this.btnAbout});
            // 
            // btnSettings
            // 
            this.btnSettings.ImageLarge = global::kiosko_ssms.Properties.Resources.server_gear_1;
            this.btnSettings.ImageSmall = global::kiosko_ssms.Properties.Resources.server_gear_1;
            this.btnSettings.TextLine1 = "CONFIGURACIÓN";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.ImageLarge = global::kiosko_ssms.Properties.Resources.msg_information_1;
            this.btnAbout.ImageSmall = global::kiosko_ssms.Properties.Resources.msg_information_1;
            this.btnAbout.TextLine1 = "ACERCA DE";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // mainTimer
            // 
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // ssMain
            // 
            this.ssMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssDate,
            this.tssClock});
            this.ssMain.Location = new System.Drawing.Point(0, 455);
            this.ssMain.Name = "ssMain";
            this.ssMain.ProgressBars = null;
            this.ssMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.ssMain.Size = new System.Drawing.Size(1669, 26);
            this.ssMain.TabIndex = 5;
            this.ssMain.Text = "kryptonStatusStrip1";
            // 
            // tssDate
            // 
            this.tssDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssDate.ForeColor = System.Drawing.Color.DarkRed;
            this.tssDate.Name = "tssDate";
            this.tssDate.Size = new System.Drawing.Size(1524, 21);
            this.tssDate.Spring = true;
            this.tssDate.Text = "<---DATE--->";
            this.tssDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tssClock
            // 
            this.tssClock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssClock.ForeColor = System.Drawing.Color.DarkGreen;
            this.tssClock.Name = "tssClock";
            this.tssClock.Size = new System.Drawing.Size(130, 21);
            this.tssClock.Text = "<----CLOCK---->";
            this.tssClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kiosko_ssms.Properties.Resources.Setup1;
            this.ClientSize = new System.Drawing.Size(1669, 481);
            this.CloseBox = false;
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.mainRibbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KIOSKO v0.7 = SISTEMA SIMPLE DE GESTIÓN DE VENTAS";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).EndInit();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
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
        private Krypton.Ribbon.KryptonRibbonTab helpTab;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple6;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnAbout;
        private Krypton.Ribbon.KryptonRibbonGroup rbPresentationsGroup;
        private Krypton.Ribbon.KryptonRibbonGroupLines kryptonRibbonGroupLines1;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnPresentationList;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnNewPresentation;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnEditPresentation;
        private Krypton.Ribbon.KryptonRibbonGroup rbVouchersGroup;
        private Krypton.Ribbon.KryptonRibbonGroupLines kryptonRibbonGroupLines2;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnVoucherList;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnSettings;
        private System.Windows.Forms.Timer mainTimer;
        private Krypton.Toolkit.KryptonStatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tssClock;
        private System.Windows.Forms.ToolStripStatusLabel tssDate;
        private Krypton.Ribbon.KryptonRibbonTab moreTab;
        private Krypton.Ribbon.KryptonRibbonGroup rbPaymentTypesGroup;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple7;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnPaymentTypeList;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnManagePaymentType;
        private Krypton.Ribbon.KryptonRibbonGroup rbVoucherTypesGroup;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple8;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnVoucherTypeList;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnManageVoucherTypes;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnNewVoucherType;
    }
}