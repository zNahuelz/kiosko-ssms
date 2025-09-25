namespace kiosko_ssms.Forms
{
    partial class SaleDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleDialog));
            this.btnOk = new System.Windows.Forms.Button();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSaleValue = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.Green;
            this.btnOk.Location = new System.Drawing.Point(211, 117);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(88, 47);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtCash.Location = new System.Drawing.Point(16, 32);
            this.txtCash.MaxLength = 10;
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(173, 47);
            this.txtCash.TabIndex = 2;
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txtCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.Location = new System.Drawing.Point(51, 9);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(102, 20);
            this.lblCash.TabIndex = 3;
            this.lblCash.Text = "EFECTIVO:";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(61, 94);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(83, 20);
            this.lblChange.TabIndex = 5;
            this.lblChange.Text = "CAMBIO:";
            // 
            // txtChange
            // 
            this.txtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.ForeColor = System.Drawing.Color.Red;
            this.txtChange.Location = new System.Drawing.Point(16, 117);
            this.txtChange.MaxLength = 10;
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(173, 47);
            this.txtChange.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(211, 32);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 47);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSaleValue});
            this.statusStrip1.Location = new System.Drawing.Point(0, 175);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(318, 26);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSaleValue
            // 
            this.lblSaleValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleValue.Name = "lblSaleValue";
            this.lblSaleValue.Size = new System.Drawing.Size(134, 21);
            this.lblSaleValue.Text = "MONTO VENTA: ";
            // 
            // SaleDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 201);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaleDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ÁREA DE PAGOS";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSaleValue;
    }
}