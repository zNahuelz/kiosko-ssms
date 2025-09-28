namespace kiosko_ssms.Forms
{
    partial class VoucherTypeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoucherTypeList));
            this.dgvVoucherType = new Krypton.Toolkit.KryptonDataGridView();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.lblMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnRefresh = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucherType)).BeginInit();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVoucherType
            // 
            this.dgvVoucherType.AllowUserToAddRows = false;
            this.dgvVoucherType.AllowUserToDeleteRows = false;
            this.dgvVoucherType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVoucherType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoucherType.Location = new System.Drawing.Point(12, 12);
            this.dgvVoucherType.Name = "dgvVoucherType";
            this.dgvVoucherType.ReadOnly = true;
            this.dgvVoucherType.Size = new System.Drawing.Size(650, 514);
            this.dgvVoucherType.TabIndex = 0;
            this.dgvVoucherType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVoucherType_CellClick);
            this.dgvVoucherType.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVoucherType_CellDoubleClick);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMessage});
            this.ssMain.Location = new System.Drawing.Point(0, 563);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(678, 22);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Teal;
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(195, 17);
            this.lblMessage.Text = "TIP: Doble click para copiar ID";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(267, 532);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.btnRefresh.Size = new System.Drawing.Size(145, 25);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRefresh.Values.Text = "REFRESCAR";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // VoucherTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 585);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.dgvVoucherType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VoucherTypeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LISTADO DE TIPOS DE COMPROBANTES DE VENTA";
            this.Load += new System.EventHandler(this.VoucherTypeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucherType)).EndInit();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgvVoucherType;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel lblMessage;
        private Krypton.Toolkit.KryptonButton btnRefresh;
    }
}