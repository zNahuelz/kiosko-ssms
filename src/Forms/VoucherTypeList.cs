using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using kiosko_ssms.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class VoucherTypeList : Krypton.Toolkit.KryptonForm
    {
        List<VoucherType> voucherTypes = new List<VoucherType>();
        public VoucherTypeList()
        {
            InitializeComponent();
        }
        private void VoucherTypeList_Load(object sender, EventArgs e)
        {
            FillVoucherTypes();
        }

        private void FillVoucherTypes()
        {
            using (var context = new AppDbContext())
            {
                voucherTypes = new VoucherService(context).GetAllVoucherTypes(true);
            }
            dgvVoucherType.DataSource = voucherTypes;
            if (voucherTypes.Any())
            {
                ConfigureTable(dgvVoucherType);
            }
            else
            {
                lblMessage.Text = "No hay tipos de comprobantes registrados.";
            }
        }

        private void ConfigureTable(DataGridView dgv)
        {
            dgv.Columns[0].HeaderText = "#";
            dgv.Columns[1].HeaderText = "NOMBRE";
            dgv.Columns[2].HeaderText = "¿ELIMINADO?";
            dgv.Columns[3].HeaderText = "CREACIÓN";
            dgv.Columns[4].HeaderText = "ULT. MOD.";
            dgv.Columns[0].Width = 50;
            dgv.Columns[1].Width = 100;
            dgv.Columns[2].Width = 100;
            dgv.Columns[3].Width = 160;
            dgv.Columns[4].Width = 160;
        }

        private void dgvVoucherType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvVoucherType.CurrentRow.Selected = true;
        }

        private void dgvVoucherType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                VoucherType voucherType = (VoucherType)dgvVoucherType.CurrentRow.DataBoundItem;
                if (voucherType != null)
                {
                    Clipboard.SetText(voucherType.Id.ToString());
                    lblMessage.Text = $"ID: {voucherType.Id} copiado al portapapeles.";
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            voucherTypes.Clear();
            FillVoucherTypes();
        }
    }
}
