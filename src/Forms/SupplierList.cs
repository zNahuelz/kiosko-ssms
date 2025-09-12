using kiosko_ssms.Data.Entities;
using kiosko_ssms.Services;
using kiosko_ssms.Utils;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class SupplierList : Krypton.Toolkit.KryptonForm
    {
        private List<Supplier> suppliers = new List<Supplier>();
        private string lastSearchMode = "";
        public SupplierList()
        {
            InitializeComponent();
        }

        private void ConfigureTable(DataGridView dgv)
        {

            dgv.Columns[3].Visible = false;
            dgv.Columns[5].Visible = false;
            dgv.Columns[8].Visible = false;

            dgv.Columns[0].HeaderText = "#";
            dgv.Columns[1].HeaderText = "NOMBRE";
            dgv.Columns[2].HeaderText = "RUC";
            dgv.Columns[4].HeaderText = "TELÉFONO";
            dgv.Columns[6].HeaderText = "DESCRIPCIÓN";
            dgv.Columns[7].HeaderText = "¿ELIMINADO?";
            dgv.Columns[9].HeaderText = "ULT. MOD.";

            dgv.Columns[0].Width = 50;
            dgv.Columns[1].Width = 200;
        }

        private void FillSupplierTable(string mode = "")
        {
            try
            {
                bool showDeleted = cbVisibility.SelectedIndex == 0;
                switch (mode)
                {
                    case "BY_NAME":
                        using (var context = new Data.AppDbContext())
                        {
                            suppliers = new SupplierService(context).GetSuppliersByName(txtSearch.Text.Trim().ToUpper(), showDeleted);
                        }
                        lastSearchMode = "BY_NAME";
                        break;
                    case "BY_RUC":
                        using (var context = new Data.AppDbContext())
                        {
                            suppliers = new SupplierService(context).GetSuppliersByRUC(txtSearch.Text.Trim(), showDeleted);
                        }
                        lastSearchMode = "BY_RUC";
                        break;
                    default:
                        using (var context = new Data.AppDbContext())
                        {
                            suppliers = new SupplierService(context).GetAllSuppliers(showDeleted);
                        }
                        lastSearchMode = "";
                        break;
                }
                dgvSuppliers.DataSource = suppliers;
                ConfigureTable(dgvSuppliers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillSearchModes()
        {
            cbSearchMode.DataSource = Constants.SupplierSearchModes;
            FillSupplierTable();
        }

        private void FillVisibilityOptions()
        {
            cbVisibility.DataSource = Constants.VisibilityOptions;
        }

        private void SupplierList_Load(object sender, EventArgs e)
        {
            FillSearchModes();
            FillVisibilityOptions();
            FillSupplierTable();
            txtSearch.Focus();
        }

        private void cbVisibility_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSupplierTable(lastSearchMode);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cbSearchMode.SelectedIndex)
            {
                case 0:
                    if (txtSearch.Text.Trim().Length >= 3)
                    {
                        FillSupplierTable("BY_NAME");
                    }
                    else
                    {
                        FillSupplierTable();
                    }
                    break;
                case 1:
                    if (Regex.IsMatch(txtSearch.Text.Trim(), @"^\+?\d{6,15}$"))
                    {
                        FillSupplierTable("BY_RUC");
                    }
                    else
                    {
                        FillSupplierTable();
                    }
                    break;
                default:
                    FillSupplierTable();
                    break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FillSupplierTable();
            txtSearch.Clear();
            cbSearchMode.SelectedIndex = 0;
            cbVisibility.SelectedIndex = 0;
            txtSearch.Focus();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSearch.PerformClick();
            }

            if (txtSearch.Text.Length >= 3 && (cbSearchMode.SelectedIndex == 0))
            {
                btnSearch.PerformClick();
            }
        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSuppliers.CurrentRow.Selected = true;
        }

        private void dgvSuppliers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedSupplier = dgvSuppliers.Rows[e.RowIndex].DataBoundItem as Supplier;
                if (selectedSupplier != null)
                {
                    Main parent = this.MdiParent as Main;
                    if (parent != null)
                    {
                        parent.OpenForm(ref parent.supplierDetailForm,
                            (s, ev) => parent.CloseForm(ref parent.supplierDetailForm, s, ev));
                        parent.supplierDetailForm.LoadSupplier(selectedSupplier);
                    }
                }
            }
        }
    }
}
