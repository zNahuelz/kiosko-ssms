namespace kiosko_ssms.Forms
{
    partial class NewSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSale));
            this.dgvCart = new Krypton.Toolkit.KryptonDataGridView();
            this.gbCustomer = new Krypton.Toolkit.KryptonGroupBox();
            this.lblSurnames = new System.Windows.Forms.Label();
            this.lblNames = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.btnUnlockCustomerSearch = new System.Windows.Forms.Button();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.gbAddProduct = new Krypton.Toolkit.KryptonGroupBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.gbSaleInfo = new Krypton.Toolkit.KryptonGroupBox();
            this.cbPaymentType = new Krypton.Toolkit.KryptonComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbShoppingCart = new Krypton.Toolkit.KryptonGroupBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnRemoveElement = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSubtractElement = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbCustomer.Panel)).BeginInit();
            this.gbCustomer.Panel.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbAddProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbAddProduct.Panel)).BeginInit();
            this.gbAddProduct.Panel.SuspendLayout();
            this.gbAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbSaleInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbSaleInfo.Panel)).BeginInit();
            this.gbSaleInfo.Panel.SuspendLayout();
            this.gbSaleInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaymentType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbShoppingCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbShoppingCart.Panel)).BeginInit();
            this.gbShoppingCart.Panel.SuspendLayout();
            this.gbShoppingCart.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgvCart.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgvCart.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Sheet;
            this.dgvCart.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Sheet;
            this.dgvCart.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Sheet;
            this.dgvCart.Location = new System.Drawing.Point(3, 5);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.Size = new System.Drawing.Size(571, 543);
            this.dgvCart.TabIndex = 4;
            this.dgvCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellClick);
            this.dgvCart.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCart_CellMouseDown);
            // 
            // gbCustomer
            // 
            this.gbCustomer.Location = new System.Drawing.Point(599, 12);
            // 
            // gbCustomer.Panel
            // 
            this.gbCustomer.Panel.Controls.Add(this.lblSurnames);
            this.gbCustomer.Panel.Controls.Add(this.lblNames);
            this.gbCustomer.Panel.Controls.Add(this.lblDni);
            this.gbCustomer.Panel.Controls.Add(this.btnUnlockCustomerSearch);
            this.gbCustomer.Panel.Controls.Add(this.btnSearchCustomer);
            this.gbCustomer.Panel.Controls.Add(this.txtDni);
            this.gbCustomer.Size = new System.Drawing.Size(461, 129);
            this.gbCustomer.TabIndex = 5;
            this.gbCustomer.Values.Heading = "INFORMACIÓN CLIENTE";
            // 
            // lblSurnames
            // 
            this.lblSurnames.AutoSize = true;
            this.lblSurnames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.lblSurnames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurnames.ForeColor = System.Drawing.Color.Black;
            this.lblSurnames.Location = new System.Drawing.Point(17, 56);
            this.lblSurnames.Name = "lblSurnames";
            this.lblSurnames.Size = new System.Drawing.Size(83, 16);
            this.lblSurnames.TabIndex = 35;
            this.lblSurnames.Text = "APELLIDO:";
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.lblNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNames.ForeColor = System.Drawing.Color.Black;
            this.lblNames.Location = new System.Drawing.Point(17, 34);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(76, 16);
            this.lblNames.TabIndex = 34;
            this.lblNames.Text = "NOMBRE:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.Black;
            this.lblDni.Location = new System.Drawing.Point(17, 12);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(37, 16);
            this.lblDni.TabIndex = 11;
            this.lblDni.Text = "DNI:";
            // 
            // btnUnlockCustomerSearch
            // 
            this.btnUnlockCustomerSearch.Image = global::kiosko_ssms.Properties.Resources.check_0;
            this.btnUnlockCustomerSearch.Location = new System.Drawing.Point(390, 56);
            this.btnUnlockCustomerSearch.Name = "btnUnlockCustomerSearch";
            this.btnUnlockCustomerSearch.Size = new System.Drawing.Size(42, 38);
            this.btnUnlockCustomerSearch.TabIndex = 33;
            this.btnUnlockCustomerSearch.UseVisualStyleBackColor = true;
            this.btnUnlockCustomerSearch.Click += new System.EventHandler(this.btnUnlockCustomerSearch_Click);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.Location = new System.Drawing.Point(224, 56);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(160, 38);
            this.btnSearchCustomer.TabIndex = 32;
            this.btnSearchCustomer.Text = "BUSCAR";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.ForeColor = System.Drawing.Color.Red;
            this.txtDni.Location = new System.Drawing.Point(224, 12);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(208, 38);
            this.txtDni.TabIndex = 31;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // gbAddProduct
            // 
            this.gbAddProduct.Location = new System.Drawing.Point(599, 147);
            // 
            // gbAddProduct.Panel
            // 
            this.gbAddProduct.Panel.Controls.Add(this.btnAddProduct);
            this.gbAddProduct.Panel.Controls.Add(this.txtBarcode);
            this.gbAddProduct.Size = new System.Drawing.Size(461, 137);
            this.gbAddProduct.TabIndex = 6;
            this.gbAddProduct.Values.Heading = "AGREGAR PRODUCTO";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(146, 62);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(160, 38);
            this.btnAddProduct.TabIndex = 34;
            this.btnAddProduct.Text = "AÑADIR";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.ForeColor = System.Drawing.Color.Red;
            this.txtBarcode.Location = new System.Drawing.Point(20, 18);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(412, 38);
            this.txtBarcode.TabIndex = 34;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // gbSaleInfo
            // 
            this.gbSaleInfo.Location = new System.Drawing.Point(599, 290);
            // 
            // gbSaleInfo.Panel
            // 
            this.gbSaleInfo.Panel.Controls.Add(this.cbPaymentType);
            this.gbSaleInfo.Panel.Controls.Add(this.lblTotal);
            this.gbSaleInfo.Panel.Controls.Add(this.lblTax);
            this.gbSaleInfo.Panel.Controls.Add(this.lblSubtotal);
            this.gbSaleInfo.Size = new System.Drawing.Size(461, 193);
            this.gbSaleInfo.TabIndex = 7;
            this.gbSaleInfo.Values.Heading = "INFORMACIÓN DE VENTA";
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentType.DropDownWidth = 154;
            this.cbPaymentType.Location = new System.Drawing.Point(36, 19);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.Size = new System.Drawing.Size(219, 22);
            this.cbPaymentType.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbPaymentType.TabIndex = 10;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotal.Location = new System.Drawing.Point(89, 128);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(166, 31);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "TOTAL: xxx";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTax.Location = new System.Drawing.Point(132, 89);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(123, 31);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "IGV: xxx";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.Black;
            this.lblSubtotal.Location = new System.Drawing.Point(30, 44);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(225, 31);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "SUBTOTAL: xxx";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSave.Location = new System.Drawing.Point(862, 489);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(198, 104);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "GUARDAR VENTA";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClearCart
            // 
            this.btnClearCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCart.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnClearCart.Location = new System.Drawing.Point(726, 489);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(130, 104);
            this.btnClearCart.TabIndex = 12;
            this.btnClearCart.Text = "LIMPIAR CARRITO";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(599, 489);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 104);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbShoppingCart
            // 
            this.gbShoppingCart.Location = new System.Drawing.Point(12, 12);
            this.gbShoppingCart.PaletteMode = Krypton.Toolkit.PaletteMode.Office2013White;
            // 
            // gbShoppingCart.Panel
            // 
            this.gbShoppingCart.Panel.Controls.Add(this.dgvCart);
            this.gbShoppingCart.Size = new System.Drawing.Size(581, 575);
            this.gbShoppingCart.TabIndex = 14;
            this.gbShoppingCart.Values.Heading = "CARRITO DE COMPRAS";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblInfo});
            this.statusStrip.Location = new System.Drawing.Point(0, 606);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1088, 30);
            this.statusStrip.TabIndex = 15;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(760, 25);
            this.lblInfo.Text = "Ingrese y valide DNI de cliente para realizar venta -- Use DNI 0 para cliente ord" +
    "inario";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // contextMenu
            // 
            this.contextMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRemoveElement,
            this.btnSubtractElement});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(116, 48);
            // 
            // btnRemoveElement
            // 
            this.btnRemoveElement.Name = "btnRemoveElement";
            this.btnRemoveElement.Size = new System.Drawing.Size(115, 22);
            this.btnRemoveElement.Text = "QUITAR";
            this.btnRemoveElement.Click += new System.EventHandler(this.btnRemoveElement_Click);
            // 
            // btnSubtractElement
            // 
            this.btnSubtractElement.Name = "btnSubtractElement";
            this.btnSubtractElement.Size = new System.Drawing.Size(115, 22);
            this.btnSubtractElement.Text = "RESTAR";
            this.btnSubtractElement.Click += new System.EventHandler(this.btnSubtractElement_Click);
            // 
            // NewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 636);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gbShoppingCart);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbSaleInfo);
            this.Controls.Add(this.gbAddProduct);
            this.Controls.Add(this.gbCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NUEVA VENTA";
            this.Load += new System.EventHandler(this.NewSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbCustomer.Panel)).EndInit();
            this.gbCustomer.Panel.ResumeLayout(false);
            this.gbCustomer.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbCustomer)).EndInit();
            this.gbCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbAddProduct.Panel)).EndInit();
            this.gbAddProduct.Panel.ResumeLayout(false);
            this.gbAddProduct.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbAddProduct)).EndInit();
            this.gbAddProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbSaleInfo.Panel)).EndInit();
            this.gbSaleInfo.Panel.ResumeLayout(false);
            this.gbSaleInfo.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbSaleInfo)).EndInit();
            this.gbSaleInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbPaymentType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbShoppingCart.Panel)).EndInit();
            this.gbShoppingCart.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbShoppingCart)).EndInit();
            this.gbShoppingCart.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgvCart;
        private Krypton.Toolkit.KryptonGroupBox gbCustomer;
        private Krypton.Toolkit.KryptonGroupBox gbAddProduct;
        private Krypton.Toolkit.KryptonGroupBox gbSaleInfo;
        private Krypton.Toolkit.KryptonComboBox cbPaymentType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnUnlockCustomerSearch;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSurnames;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.Label lblDni;
        private Krypton.Toolkit.KryptonGroupBox gbShoppingCart;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblInfo;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem btnRemoveElement;
        private System.Windows.Forms.ToolStripMenuItem btnSubtractElement;
    }
}