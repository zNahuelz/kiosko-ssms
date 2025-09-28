using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using kiosko_ssms.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class PaymentTypeList : Krypton.Toolkit.KryptonForm
    {
        List<PaymentType> paymentTypes = new List<PaymentType>();
        public PaymentTypeList()
        {
            InitializeComponent();
        }

        private void PaymentTypeList_Load(object sender, EventArgs e)
        {
            FillPaymentTypes();
        }

        private void FillPaymentTypes()
        {
            using (var context = new AppDbContext())
            {
                paymentTypes = new PaymentTypeService(context).GetAllPaymentTypes(true);
            }
            dgvPaymentType.DataSource = paymentTypes;
            if (paymentTypes.Any())
            {
                ConfigureTable(dgvPaymentType);
            }
            else
            {
                lblMessage.Text = "No hay tipos de pago registrados.";
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
            dgv.Columns[1].Width = 160;
            dgv.Columns[2].Width = 100;
            dgv.Columns[3].Width = 160;
            dgv.Columns[4].Width = 160;
        }

        private void dgvPaymentType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPaymentType.CurrentRow.Selected = true;
        }

        private void dgvPaymentType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                PaymentType paymentType = (PaymentType)dgvPaymentType.CurrentRow.DataBoundItem;
                if (paymentType != null)
                {
                    Clipboard.SetText(paymentType.Id.ToString());
                    lblMessage.Text = $"ID: {paymentType.Id} copiado al portapapeles.";
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            paymentTypes.Clear();
            FillPaymentTypes();
        }
    }
}
