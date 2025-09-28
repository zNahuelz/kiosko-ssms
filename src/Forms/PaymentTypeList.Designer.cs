namespace kiosko_ssms.Forms
{
    partial class PaymentTypeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentTypeList));
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.lblMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvPaymentType = new Krypton.Toolkit.KryptonDataGridView();
            this.btnRefresh = new Krypton.Toolkit.KryptonButton();
            this.ssMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentType)).BeginInit();
            this.SuspendLayout();
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMessage});
            this.ssMain.Location = new System.Drawing.Point(0, 552);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(682, 22);
            this.ssMain.TabIndex = 3;
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
            // dgvPaymentType
            // 
            this.dgvPaymentType.AllowUserToAddRows = false;
            this.dgvPaymentType.AllowUserToDeleteRows = false;
            this.dgvPaymentType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPaymentType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentType.Location = new System.Drawing.Point(12, 12);
            this.dgvPaymentType.Name = "dgvPaymentType";
            this.dgvPaymentType.ReadOnly = true;
            this.dgvPaymentType.Size = new System.Drawing.Size(650, 508);
            this.dgvPaymentType.TabIndex = 2;
            this.dgvPaymentType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentType_CellClick);
            this.dgvPaymentType.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentType_CellDoubleClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(269, 524);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.btnRefresh.Size = new System.Drawing.Size(145, 25);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRefresh.Values.Text = "REFRESCAR";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // PaymentTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 574);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.dgvPaymentType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentTypeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LISTADO DE TIPOS DE PAGOS";
            this.Load += new System.EventHandler(this.PaymentTypeList_Load);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel lblMessage;
        private Krypton.Toolkit.KryptonDataGridView dgvPaymentType;
        private Krypton.Toolkit.KryptonButton btnRefresh;
    }
}