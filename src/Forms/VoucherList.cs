using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using kiosko_ssms.Services;
using kiosko_ssms.Utils;
using Krypton.Ribbon;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class VoucherList : Krypton.Toolkit.KryptonForm
    {
        private List<Voucher> vouchers = new List<Voucher>();

        public VoucherList()
        {
            InitializeComponent();
            dtpDate.Enabled = false;
        }

        private void ConfigureTable(DataGridView dgv)
        {
            dgv.Columns[2].Visible = false;
            dgv.Columns[6].Visible = false;
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].Visible = false;
            dgv.Columns[10].Visible = false;
            dgv.Columns[11].Visible = false;
            dgv.Columns[12].Visible = false;
            dgv.Columns[13].Visible = false;

            dgv.Columns[0].HeaderText = "#";
            dgv.Columns[1].HeaderText = "IGV";
            dgv.Columns[3].HeaderText = "SUBTOTAL";
            dgv.Columns[4].HeaderText = "TOTAL";
            dgv.Columns[5].HeaderText = "CAMBIO";
            dgv.Columns[9].HeaderText = "FECHA VENTA";
            dgv.Columns[14].HeaderText = "CLIENTE";
            dgv.Columns[15].HeaderText = "TIPO COMP.";
            dgv.Columns[16].HeaderText = "TIPO PAGO";
        }

        private void FillVoucherTable(string mode = "")
        {
            try
            {
                switch (mode)
                {
                    case "BY_ID":
                        using (var context = new AppDbContext())
                        {
                            vouchers = new VoucherService(context).GetVouchersById(int.Parse(txtSearch.Text.Trim()), true);
                        }
                        break;
                    case "BY_DNI":
                        using (var context = new AppDbContext())
                        {
                            vouchers = new VoucherService(context).GetVouchersByDNI(txtSearch.Text.Trim(), true);
                        }
                        break;
                    case "BY_DATE":
                        using (var context = new AppDbContext())
                        {
                            vouchers = new VoucherService(context).GetVouchersByDate(dtpDate.Value.Date, true);
                        }
                        break;
                    default:
                        using (var context = new AppDbContext())
                        {
                            vouchers = new VoucherService(context).GetAllVouchers(true);
                        }
                        break;
                }
                dgvVouchers.DataSource = vouchers;
                ConfigureTable(dgvVouchers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constants.Messages.Error.DB_CONN_FAILED + ex.Message, Constants.Messages.Error.ERROR_TAG, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillSearchModes()
        {
            cbSearchMode.DataSource = Constants.VoucherSearchModes;
        }

        private void VoucherList_Load(object sender, System.EventArgs e)
        {
            FillSearchModes();
            FillVoucherTable();
            txtSearch.Focus();
        }

        private void cbSearchMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbSearchMode.SelectedIndex)
            {
                case 0:
                    dtpDate.Enabled = false;
                    txtSearch.Enabled = true;
                    break;
                case 1:
                    dtpDate.Enabled = false;
                    txtSearch.Enabled = true;
                    break;
                case 2:
                    dtpDate.Enabled = true;
                    txtSearch.Enabled = false;
                    break;
                default: goto case 0;
            }
        }

        private void dgvVouchers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvVouchers.CurrentRow.Selected = true;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSearch.PerformClick();
            }

            if (txtSearch.Text.Length >= 1 && txtSearch.Text.Length <= 15 & (cbSearchMode.SelectedIndex == 0 || cbSearchMode.SelectedIndex == 1))
            {
                btnSearch.PerformClick();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FillVoucherTable();
            txtSearch.Clear();
            cbSearchMode.SelectedIndex = 0;
            dtpDate.Value = DateTime.Now;
            txtSearch.Focus();
        }

        private void dgvVouchers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvVouchers.Columns[e.ColumnIndex].DataPropertyName == "Customer" && e.Value is Customer customer)
            {
                e.Value = $"{customer.Names} {customer.Surnames}";
            }

            if (dgvVouchers.Columns[e.ColumnIndex].DataPropertyName == "VoucherType" && e.Value is VoucherType voucherType)
            {
                e.Value = voucherType.Name;
            }

            if (dgvVouchers.Columns[e.ColumnIndex].DataPropertyName == "PaymentType" && e.Value is PaymentType paymentType)
            {
                e.Value = paymentType.Name;
            }

            if (dgvVouchers.Columns[e.ColumnIndex].DataPropertyName == "Igv" && e.Value is double Igv)
            {
                e.Value = Igv.Round(2).ToString();
            }

            if (dgvVouchers.Columns[e.ColumnIndex].DataPropertyName == "Subtotal" && e.Value is double Subtotal)
            {
                e.Value = Subtotal.Round(2).ToString();
            }

            if (dgvVouchers.Columns[e.ColumnIndex].DataPropertyName == "Total" && e.Value is double Total)
            {
                e.Value = Total.Round(2).ToString();
            }

            if (dgvVouchers.Columns[e.ColumnIndex].DataPropertyName == "Change" && e.Value is double Change)
            {
                e.Value = Change.Round(2).ToString();
            }

            if (dgvVouchers.Columns[e.ColumnIndex].DataPropertyName == "CreatedAt" && e.Value is DateTime date)
            {
                e.Value = date.ToString("dd/MM/yyyy");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cbSearchMode.SelectedIndex)
            {
                case 0:
                    try
                    {
                        int id = int.Parse(txtSearch.Text.Trim());
                        FillVoucherTable("BY_ID");
                    }
                    catch
                    {
                        MessageBox.Show(Constants.Messages.Error.ID_NOT_INTEGER, Constants.Messages.Error.ERROR_TAG, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSearch.Focus();
                        txtSearch.Clear();
                    }
                    break;
                case 1:
                    if (txtSearch.Text?.Trim().Length >= 8)
                    {
                        FillVoucherTable("BY_DNI");
                    }
                    break;
                case 2:
                    FillVoucherTable("BY_DATE");
                    break;
                default:
                    btnReset.PerformClick();
                    break;
            }
        }

        private void dgvVouchers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedVoucher = dgvVouchers.Rows[e.RowIndex].DataBoundItem as Voucher;
                if (selectedVoucher != null)
                {
                    Main parent = this.MdiParent as Main;
                    if (parent != null)
                    {
                        parent.OpenForm(ref parent.voucherDetailForm,
                            (s, ev) => parent.CloseForm(ref parent.voucherDetailForm, s, ev));
                        parent.voucherDetailForm.LoadVoucher(selectedVoucher);
                    }
                }
            }
        }
    }
}
