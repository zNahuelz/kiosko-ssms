using kiosko_ssms.Data.Entities;
using System;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class VoucherDetail : Krypton.Toolkit.KryptonForm
    {
        private Voucher _voucher;
        public VoucherDetail()
        {
            InitializeComponent();
        }


        public void LoadVoucher(Voucher voucher)
        {
            _voucher = voucher;
            txtId.Text = voucher.Id.ToString();
            txtSerial.Text = voucher.SaleSerial;
            txtCreatedAt.Text = voucher.CreatedAt.ToString("g");
            txtUpdatedAt.Text = voucher.UpdatedAt.ToString("g");
            txtPaid.Text = voucher.Paid ? "PAGADO" : "PENDIENTE PAGO";
            txtIsDeleted.Text = voucher.IsDeleted ? "ELIMINADO" : "VIGENTE";
            txtSubtotal.Text = Math.Round(voucher.Subtotal, 2).ToString();
            txtTax.Text = Math.Round(voucher.Igv, 2).ToString();
            txtTotal.Text = Math.Round(voucher.Total, 2).ToString();
            txtChange.Text = Math.Round(voucher.Change, 2).ToString();
            txtTaxPercentage.Text = (voucher.Tax * 100).ToString() + "%";
            txtCustomer.Text = $"{voucher.Customer.Names} {voucher.Customer.Surnames} - DNI: {voucher.Customer.Dni}";
            txtVoucherType.Text = voucher.VoucherType.Name;
            txtPaymentType.Text = voucher.PaymentType.Name;
            FillVoucherDetails();
        }

        private void FillVoucherDetails()
        {
            dgvVoucherDetail.DataSource = _voucher.VoucherDetails;
            ConfigureTable(dgvVoucherDetail);
        }

        private void ConfigureTable(DataGridView dgv)
        {
            dgv.Columns[0].Visible = false;
            dgv.Columns[4].Visible = false;
            dgv.Columns[5].Visible = false;
            dgv.Columns[6].Visible = false;
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].Visible = false;

            dgv.Columns[1].HeaderText = "CANTIDAD";
            dgv.Columns[2].HeaderText = "PRECIO UNITARIO";
            dgv.Columns[3].HeaderText = "SUBTOTAL";
            dgv.Columns[10].HeaderText = "PRODUCTO";

            dgv.Columns[1].Width = 100;
            dgv.Columns[2].Width = 100;
            dgv.Columns[3].Width = 100;
            dgv.Columns[10].Width = 400;
        }

        private void dgvVoucherDetail_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvVoucherDetail.Columns[e.ColumnIndex].DataPropertyName == "Product" && e.Value is Product product)
            {
                e.Value = product.Name;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
