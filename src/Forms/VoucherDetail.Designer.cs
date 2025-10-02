namespace kiosko_ssms.Forms
{
    partial class VoucherDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoucherDetail));
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtId = new Krypton.Toolkit.KryptonTextBox();
            this.btnExit = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.txtSerial = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.txtCreatedAt = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.txtUpdatedAt = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.txtPaid = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.txtIsDeleted = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.txtSubtotal = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.txtTax = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.txtTotal = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            this.txtChange = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel12 = new Krypton.Toolkit.KryptonLabel();
            this.txtTaxPercentage = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.txtCustomer = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel13 = new Krypton.Toolkit.KryptonLabel();
            this.txtVoucherType = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel14 = new Krypton.Toolkit.KryptonLabel();
            this.txtPaymentType = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel15 = new Krypton.Toolkit.KryptonLabel();
            this.dgvVoucherDetail = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucherDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(11, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(22, 20);
            this.kryptonLabel1.TabIndex = 31;
            this.kryptonLabel1.Values.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(65, 12);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(224, 23);
            this.txtId.TabIndex = 29;
            this.txtId.Text = "kryptonTextBox1";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 487);
            this.btnExit.Name = "btnExit";
            this.btnExit.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleOrangeLightMode;
            this.btnExit.Size = new System.Drawing.Size(277, 36);
            this.btnExit.TabIndex = 28;
            this.btnExit.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnExit.Values.Text = "CERRAR";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(11, 52);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel2.TabIndex = 34;
            this.kryptonLabel2.Values.Text = "SERIAL";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(65, 51);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.ReadOnly = true;
            this.txtSerial.Size = new System.Drawing.Size(224, 23);
            this.txtSerial.TabIndex = 33;
            this.txtSerial.Text = "kryptonTextBox1";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(11, 91);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(61, 36);
            this.kryptonLabel4.TabIndex = 36;
            this.kryptonLabel4.Values.Text = "FECHA\r\nCOMPRA";
            // 
            // txtCreatedAt
            // 
            this.txtCreatedAt.Location = new System.Drawing.Point(78, 98);
            this.txtCreatedAt.Name = "txtCreatedAt";
            this.txtCreatedAt.ReadOnly = true;
            this.txtCreatedAt.Size = new System.Drawing.Size(211, 23);
            this.txtCreatedAt.TabIndex = 35;
            this.txtCreatedAt.Text = "kryptonTextBox1";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(11, 143);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(42, 36);
            this.kryptonLabel5.TabIndex = 38;
            this.kryptonLabel5.Values.Text = "ULT.\r\nMOD.";
            // 
            // txtUpdatedAt
            // 
            this.txtUpdatedAt.Location = new System.Drawing.Point(78, 150);
            this.txtUpdatedAt.Name = "txtUpdatedAt";
            this.txtUpdatedAt.ReadOnly = true;
            this.txtUpdatedAt.Size = new System.Drawing.Size(211, 23);
            this.txtUpdatedAt.TabIndex = 37;
            this.txtUpdatedAt.Text = "kryptonTextBox1";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(11, 197);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(56, 20);
            this.kryptonLabel6.TabIndex = 40;
            this.kryptonLabel6.Values.Text = "ESTADO";
            // 
            // txtPaid
            // 
            this.txtPaid.Location = new System.Drawing.Point(78, 196);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.ReadOnly = true;
            this.txtPaid.Size = new System.Drawing.Size(211, 23);
            this.txtPaid.TabIndex = 39;
            this.txtPaid.Text = "kryptonTextBox1";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(11, 236);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(87, 20);
            this.kryptonLabel7.TabIndex = 42;
            this.kryptonLabel7.Values.Text = "¿ELIMINADO?";
            // 
            // txtIsDeleted
            // 
            this.txtIsDeleted.Location = new System.Drawing.Point(104, 235);
            this.txtIsDeleted.Name = "txtIsDeleted";
            this.txtIsDeleted.ReadOnly = true;
            this.txtIsDeleted.Size = new System.Drawing.Size(185, 23);
            this.txtIsDeleted.TabIndex = 41;
            this.txtIsDeleted.Text = "kryptonTextBox2";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(11, 279);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel8.TabIndex = 44;
            this.kryptonLabel8.Values.Text = "SUBTOTAL";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(78, 278);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(211, 23);
            this.txtSubtotal.TabIndex = 43;
            this.txtSubtotal.Text = "kryptonTextBox2";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(11, 319);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel9.TabIndex = 46;
            this.kryptonLabel9.Values.Text = "IMPUESTO";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(78, 318);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(211, 23);
            this.txtTax.TabIndex = 45;
            this.txtTax.Text = "kryptonTextBox3";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(11, 359);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(47, 20);
            this.kryptonLabel10.TabIndex = 48;
            this.kryptonLabel10.Values.Text = "TOTAL";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(78, 358);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(211, 23);
            this.txtTotal.TabIndex = 47;
            this.txtTotal.Text = "kryptonTextBox4";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(11, 400);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(57, 20);
            this.kryptonLabel11.TabIndex = 50;
            this.kryptonLabel11.Values.Text = "CAMBIO";
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(78, 399);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(211, 23);
            this.txtChange.TabIndex = 49;
            this.txtChange.Text = "kryptonTextBox5";
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(11, 440);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(90, 20);
            this.kryptonLabel12.TabIndex = 52;
            this.kryptonLabel12.Values.Text = "IMPUESTO (%)";
            // 
            // txtTaxPercentage
            // 
            this.txtTaxPercentage.Location = new System.Drawing.Point(117, 439);
            this.txtTaxPercentage.Name = "txtTaxPercentage";
            this.txtTaxPercentage.ReadOnly = true;
            this.txtTaxPercentage.Size = new System.Drawing.Size(172, 23);
            this.txtTaxPercentage.TabIndex = 51;
            this.txtTaxPercentage.Text = "kryptonTextBox5";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(320, 14);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(55, 20);
            this.kryptonLabel3.TabIndex = 54;
            this.kryptonLabel3.Values.Text = "CLIENTE";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(381, 13);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(295, 23);
            this.txtCustomer.TabIndex = 53;
            this.txtCustomer.Text = "kryptonTextBox1";
            // 
            // kryptonLabel13
            // 
            this.kryptonLabel13.Location = new System.Drawing.Point(684, 14);
            this.kryptonLabel13.Name = "kryptonLabel13";
            this.kryptonLabel13.Size = new System.Drawing.Size(78, 20);
            this.kryptonLabel13.TabIndex = 56;
            this.kryptonLabel13.Values.Text = "TIPO COMP.";
            // 
            // txtVoucherType
            // 
            this.txtVoucherType.Location = new System.Drawing.Point(768, 12);
            this.txtVoucherType.Name = "txtVoucherType";
            this.txtVoucherType.ReadOnly = true;
            this.txtVoucherType.Size = new System.Drawing.Size(149, 23);
            this.txtVoucherType.TabIndex = 55;
            this.txtVoucherType.Text = "kryptonTextBox1";
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Location = new System.Drawing.Point(933, 14);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(73, 20);
            this.kryptonLabel14.TabIndex = 58;
            this.kryptonLabel14.Values.Text = "MET. PAGO";
            // 
            // txtPaymentType
            // 
            this.txtPaymentType.Location = new System.Drawing.Point(1017, 12);
            this.txtPaymentType.Name = "txtPaymentType";
            this.txtPaymentType.ReadOnly = true;
            this.txtPaymentType.Size = new System.Drawing.Size(113, 23);
            this.txtPaymentType.TabIndex = 57;
            this.txtPaymentType.Text = "kryptonTextBox1";
            // 
            // kryptonLabel15
            // 
            this.kryptonLabel15.Location = new System.Drawing.Point(320, 54);
            this.kryptonLabel15.Name = "kryptonLabel15";
            this.kryptonLabel15.Size = new System.Drawing.Size(160, 20);
            this.kryptonLabel15.TabIndex = 59;
            this.kryptonLabel15.Values.Text = "PRODUCTOS COMPRADOS";
            // 
            // dgvVoucherDetail
            // 
            this.dgvVoucherDetail.AllowUserToAddRows = false;
            this.dgvVoucherDetail.AllowUserToDeleteRows = false;
            this.dgvVoucherDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVoucherDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoucherDetail.Location = new System.Drawing.Point(320, 98);
            this.dgvVoucherDetail.Name = "dgvVoucherDetail";
            this.dgvVoucherDetail.ReadOnly = true;
            this.dgvVoucherDetail.Size = new System.Drawing.Size(810, 364);
            this.dgvVoucherDetail.TabIndex = 60;
            this.dgvVoucherDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVoucherDetail_CellClick);
            this.dgvVoucherDetail.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVoucherDetail_CellFormatting);
            // 
            // VoucherDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 570);
            this.Controls.Add(this.dgvVoucherDetail);
            this.Controls.Add(this.kryptonLabel15);
            this.Controls.Add(this.kryptonLabel14);
            this.Controls.Add(this.txtPaymentType);
            this.Controls.Add(this.kryptonLabel13);
            this.Controls.Add(this.txtVoucherType);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.kryptonLabel12);
            this.Controls.Add(this.txtTaxPercentage);
            this.Controls.Add(this.kryptonLabel11);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.kryptonLabel10);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.kryptonLabel9);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.txtIsDeleted);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.txtUpdatedAt);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.txtCreatedAt);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VoucherDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DETALLE DE VOUCHER";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucherDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtId;
        private Krypton.Toolkit.KryptonButton btnExit;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtSerial;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonTextBox txtCreatedAt;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonTextBox txtUpdatedAt;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonTextBox txtPaid;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonTextBox txtIsDeleted;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonTextBox txtSubtotal;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonTextBox txtTax;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonTextBox txtTotal;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonTextBox txtChange;
        private Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private Krypton.Toolkit.KryptonTextBox txtTaxPercentage;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox txtCustomer;
        private Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private Krypton.Toolkit.KryptonTextBox txtVoucherType;
        private Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private Krypton.Toolkit.KryptonTextBox txtPaymentType;
        private Krypton.Toolkit.KryptonLabel kryptonLabel15;
        private Krypton.Toolkit.KryptonDataGridView dgvVoucherDetail;
    }
}