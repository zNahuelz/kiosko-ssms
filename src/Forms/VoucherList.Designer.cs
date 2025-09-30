namespace kiosko_ssms.Forms
{
    partial class VoucherList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoucherList));
            this.dgvVouchers = new Krypton.Toolkit.KryptonDataGridView();
            this.gbMain = new Krypton.Toolkit.KryptonGroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.cbSearchMode = new Krypton.Toolkit.KryptonComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new Krypton.Toolkit.KryptonTextBox();
            this.btnReset = new Krypton.Toolkit.KryptonButton();
            this.btnSearch = new Krypton.Toolkit.KryptonButton();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tssLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnViewPdf = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSavePdf = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVouchers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbMain.Panel)).BeginInit();
            this.gbMain.Panel.SuspendLayout();
            this.gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSearchMode)).BeginInit();
            this.ssMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVouchers
            // 
            this.dgvVouchers.AllowUserToAddRows = false;
            this.dgvVouchers.AllowUserToDeleteRows = false;
            this.dgvVouchers.AllowUserToOrderColumns = true;
            this.dgvVouchers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVouchers.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgvVouchers.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgvVouchers.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Sheet;
            this.dgvVouchers.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Sheet;
            this.dgvVouchers.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Sheet;
            this.dgvVouchers.Location = new System.Drawing.Point(12, 133);
            this.dgvVouchers.Name = "dgvVouchers";
            this.dgvVouchers.ReadOnly = true;
            this.dgvVouchers.Size = new System.Drawing.Size(950, 438);
            this.dgvVouchers.TabIndex = 4;
            this.dgvVouchers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVouchers_CellClick);
            this.dgvVouchers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVouchers_CellDoubleClick);
            this.dgvVouchers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVouchers_CellFormatting);
            this.dgvVouchers.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVouchers_CellMouseDown);
            // 
            // gbMain
            // 
            this.gbMain.Location = new System.Drawing.Point(12, 12);
            this.gbMain.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            // 
            // gbMain.Panel
            // 
            this.gbMain.Panel.Controls.Add(this.label3);
            this.gbMain.Panel.Controls.Add(this.dtpDate);
            this.gbMain.Panel.Controls.Add(this.cbSearchMode);
            this.gbMain.Panel.Controls.Add(this.label1);
            this.gbMain.Panel.Controls.Add(this.label2);
            this.gbMain.Panel.Controls.Add(this.txtSearch);
            this.gbMain.Panel.Controls.Add(this.btnReset);
            this.gbMain.Panel.Controls.Add(this.btnSearch);
            this.gbMain.Size = new System.Drawing.Size(641, 115);
            this.gbMain.TabIndex = 5;
            this.gbMain.Values.Heading = "BÚSQUEDA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(33, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "FECHA";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(96, 58);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(236, 21);
            this.dtpDate.TabIndex = 13;
            // 
            // cbSearchMode
            // 
            this.cbSearchMode.AccessibleName = "";
            this.cbSearchMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchMode.DropDownWidth = 201;
            this.cbSearchMode.Location = new System.Drawing.Point(36, 29);
            this.cbSearchMode.Name = "cbSearchMode";
            this.cbSearchMode.Size = new System.Drawing.Size(201, 22);
            this.cbSearchMode.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbSearchMode.TabIndex = 12;
            this.cbSearchMode.SelectedIndexChanged += new System.EventHandler(this.cbSearchMode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(33, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "FILTRADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(254, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "CRITERIO";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(257, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(201, 23);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(475, 49);
            this.btnReset.Name = "btnReset";
            this.btnReset.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleOrangeLightMode;
            this.btnReset.Size = new System.Drawing.Size(149, 39);
            this.btnReset.TabIndex = 8;
            this.btnReset.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnReset.Values.Image = global::kiosko_ssms.Properties.Resources.replace_directory;
            this.btnReset.Values.Text = "RESETEAR";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(475, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleOrangeLightMode;
            this.btnSearch.Size = new System.Drawing.Size(149, 39);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSearch.Values.Image = global::kiosko_ssms.Properties.Resources.search_file_3;
            this.btnSearch.Values.Text = "BUSCAR";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLabel});
            this.ssMain.Location = new System.Drawing.Point(0, 581);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(970, 26);
            this.ssMain.TabIndex = 6;
            this.ssMain.Text = "statusStrip1";
            // 
            // tssLabel
            // 
            this.tssLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.tssLabel.Name = "tssLabel";
            this.tssLabel.Size = new System.Drawing.Size(519, 21);
            this.tssLabel.Text = "TIP: DOBLE CLICK PARA VER DETALLE DE COMPROBANTE DE VENTA";
            // 
            // pbMain
            // 
            this.pbMain.Image = global::kiosko_ssms.Properties.Resources.Indexing_Service;
            this.pbMain.Location = new System.Drawing.Point(659, 24);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(303, 98);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMain.TabIndex = 7;
            this.pbMain.TabStop = false;
            // 
            // contextMenu
            // 
            this.contextMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnViewPdf,
            this.btnSavePdf});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(181, 70);
            // 
            // btnViewPdf
            // 
            this.btnViewPdf.Name = "btnViewPdf";
            this.btnViewPdf.Size = new System.Drawing.Size(180, 22);
            this.btnViewPdf.Text = "VER PDF";
            this.btnViewPdf.Click += new System.EventHandler(this.btnViewPdf_Click);
            // 
            // btnSavePdf
            // 
            this.btnSavePdf.Name = "btnSavePdf";
            this.btnSavePdf.Size = new System.Drawing.Size(180, 22);
            this.btnSavePdf.Text = "GUARDAR PDF";
            this.btnSavePdf.Click += new System.EventHandler(this.btnSavePdf_Click);
            // 
            // VoucherList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 607);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.dgvVouchers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VoucherList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LISTADO DE COMPROBANTES DE VENTA";
            this.Load += new System.EventHandler(this.VoucherList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVouchers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbMain.Panel)).EndInit();
            this.gbMain.Panel.ResumeLayout(false);
            this.gbMain.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbMain)).EndInit();
            this.gbMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbSearchMode)).EndInit();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgvVouchers;
        private Krypton.Toolkit.KryptonGroupBox gbMain;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tssLabel;
        private Krypton.Toolkit.KryptonButton btnReset;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private Krypton.Toolkit.KryptonComboBox cbSearchMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Label label3;
        private Krypton.Toolkit.KryptonDateTimePicker dtpDate;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem btnViewPdf;
        private System.Windows.Forms.ToolStripMenuItem btnSavePdf;
    }
}