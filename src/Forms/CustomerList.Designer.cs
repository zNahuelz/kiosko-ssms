namespace kiosko_ssms.Forms
{
    partial class CustomerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerList));
            this.gbMain = new Krypton.Toolkit.KryptonGroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new Krypton.Toolkit.KryptonButton();
            this.btnSearch = new Krypton.Toolkit.KryptonButton();
            this.cbVisibility = new Krypton.Toolkit.KryptonComboBox();
            this.txtSearch = new Krypton.Toolkit.KryptonTextBox();
            this.cbSearchMode = new Krypton.Toolkit.KryptonComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCustomers = new Krypton.Toolkit.KryptonDataGridView();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tssMainLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbMain.Panel)).BeginInit();
            this.gbMain.Panel.SuspendLayout();
            this.gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbVisibility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSearchMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.gbMain.Location = new System.Drawing.Point(829, 14);
            this.gbMain.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            // 
            // gbMain.Panel
            // 
            this.gbMain.Panel.AccessibleName = "cbSearchType";
            this.gbMain.Panel.Controls.Add(this.label2);
            this.gbMain.Panel.Controls.Add(this.btnReset);
            this.gbMain.Panel.Controls.Add(this.btnSearch);
            this.gbMain.Panel.Controls.Add(this.cbVisibility);
            this.gbMain.Panel.Controls.Add(this.txtSearch);
            this.gbMain.Panel.Controls.Add(this.cbSearchMode);
            this.gbMain.Panel.Controls.Add(this.label1);
            this.gbMain.Size = new System.Drawing.Size(229, 620);
            this.gbMain.TabIndex = 3;
            this.gbMain.Values.Heading = "HERRAMIENTAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(74, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "CRITERIO";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 245);
            this.btnReset.Name = "btnReset";
            this.btnReset.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleOrangeLightMode;
            this.btnReset.Size = new System.Drawing.Size(201, 46);
            this.btnReset.TabIndex = 6;
            this.btnReset.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnReset.Values.Image = global::kiosko_ssms.Properties.Resources.replace_directory;
            this.btnReset.Values.Text = "RESETEAR";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 193);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleOrangeLightMode;
            this.btnSearch.Size = new System.Drawing.Size(201, 46);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSearch.Values.Image = global::kiosko_ssms.Properties.Resources.search_file_3;
            this.btnSearch.Values.Text = "BUSCAR";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbVisibility
            // 
            this.cbVisibility.AccessibleName = "cbVisibility";
            this.cbVisibility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVisibility.DropDownWidth = 201;
            this.cbVisibility.Location = new System.Drawing.Point(12, 107);
            this.cbVisibility.Name = "cbVisibility";
            this.cbVisibility.Size = new System.Drawing.Size(201, 22);
            this.cbVisibility.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbVisibility.TabIndex = 4;
            this.cbVisibility.SelectedIndexChanged += new System.EventHandler(this.cbVisibility_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 163);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(201, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // cbSearchMode
            // 
            this.cbSearchMode.AccessibleName = "";
            this.cbSearchMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchMode.DropDownWidth = 201;
            this.cbSearchMode.Location = new System.Drawing.Point(12, 45);
            this.cbSearchMode.Name = "cbSearchMode";
            this.cbSearchMode.Size = new System.Drawing.Size(201, 22);
            this.cbSearchMode.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbSearchMode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(74, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "FILTRADO";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToOrderColumns = true;
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgvCustomers.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgvCustomers.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Sheet;
            this.dgvCustomers.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Sheet;
            this.dgvCustomers.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Sheet;
            this.dgvCustomers.Location = new System.Drawing.Point(16, 14);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.Size = new System.Drawing.Size(807, 620);
            this.dgvCustomers.TabIndex = 2;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            this.dgvCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellDoubleClick);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssMainLabel});
            this.ssMain.Location = new System.Drawing.Point(0, 647);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(1096, 22);
            this.ssMain.TabIndex = 4;
            this.ssMain.Text = "statusStrip1";
            // 
            // tssMainLabel
            // 
            this.tssMainLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssMainLabel.ForeColor = System.Drawing.Color.Teal;
            this.tssMainLabel.Name = "tssMainLabel";
            this.tssMainLabel.Size = new System.Drawing.Size(381, 17);
            this.tssMainLabel.Text = "TIP: DOBLE CLICK EN CLIENTE PARA VER DETALLE DEL MISMO.";
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 669);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.dgvCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerList";
            this.Text = "LISTADO DE CLIENTES";
            this.Load += new System.EventHandler(this.CustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbMain.Panel)).EndInit();
            this.gbMain.Panel.ResumeLayout(false);
            this.gbMain.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbMain)).EndInit();
            this.gbMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbVisibility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSearchMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox gbMain;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonButton btnReset;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private Krypton.Toolkit.KryptonComboBox cbVisibility;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private Krypton.Toolkit.KryptonComboBox cbSearchMode;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonDataGridView dgvCustomers;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tssMainLabel;
    }
}