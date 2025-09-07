using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using kiosko_ssms.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class CustomerList : Krypton.Toolkit.KryptonForm
    {
        private string lastSearchMode = "";
        public CustomerList()
        {
            InitializeComponent();
        }

        private List<Customer> customers = new List<Customer>();

        private void CustomerList_Load(object sender, EventArgs e)
        {
            FillSearchModes();
            FillVisibilityOptions();
            FillCustomersTable();
        }

        private void ConfigureTable(DataGridView dgv)
        {
            dgv.Columns[5].Visible = false;
            dgv.Columns[6].Visible = false;
            dgv.Columns[8].Visible = false;

            dgv.Columns[0].HeaderText = "#";
            dgv.Columns[1].HeaderText = "NOMBRES";
            dgv.Columns[2].HeaderText = "APELLIDOS";
            dgv.Columns[3].HeaderText = "DNI";
            dgv.Columns[4].HeaderText = "TELÉFONO";
            dgv.Columns[7].HeaderText = "¿ELIMINADO?";
            dgv.Columns[9].HeaderText = "ULT. MOD.";

            dgv.Columns[1].Width = 200;
            dgv.Columns[2].Width = 200;
            dgv.Columns[9].Width = 150;

        }

        private void FillSearchModes()
        {
            cbSearchMode.DataSource = Utils.Constants.CustomerSearchModes;
        }

        private void FillVisibilityOptions()
        {
            cbVisibility.DataSource = Utils.Constants.VisibilityOptions;
        }

        private void FillCustomersTable(string mode = "")
        {
            try
            {
                switch (mode)
                {
                    case "BY_NAME":
                        using (var context = new AppDbContext())
                        {
                            customers = new CustomerService(context).GetCustomersByName(txtSearch.Text?.Trim().ToUpper(), cbVisibility.SelectedIndex == 0 ? true : false);
                        }
                        lastSearchMode = "BY_NAME";
                        break;
                    case "BY_DNI":
                        using (var context = new AppDbContext())
                        {
                            customers = new CustomerService(context).GetCustomersByDni(txtSearch.Text?.Trim(), cbVisibility.SelectedIndex == 0 ? true : false);
                        }
                        lastSearchMode = "BY_DNI";
                        break;
                    default:
                        using (var context = new AppDbContext())
                        {
                            customers = new CustomerService(context).GetAllCustomers(cbVisibility.SelectedIndex == 0 ? true : false);
                        }
                        lastSearchMode = "";
                        break;
                }
                dgvCustomers.DataSource = customers;
                ConfigureTable(dgvCustomers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbVisibility_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCustomersTable(lastSearchMode);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cbSearchMode.SelectedIndex)
            {
                case 0:
                    if (txtSearch.Text?.Trim().Length >= 3)
                    {
                        FillCustomersTable("BY_NAME");
                    }
                    break;
                case 1:
                    if (txtSearch.Text?.Trim().Length >= 7)
                    {
                        FillCustomersTable("BY_DNI");
                    }
                    break;
                default: break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbSearchMode.SelectedIndex = 0;
            cbVisibility.SelectedIndex = 0;
            FillCustomersTable();
            txtSearch.Clear();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSearch.PerformClick();
            }

            if (txtSearch.Text?.Trim().Length >= 3 && cbSearchMode.SelectedIndex == 0)
            {
                btnSearch.PerformClick();
                return;
            }
            if (txtSearch.Text?.Trim().Length >= 7 && cbSearchMode.SelectedIndex == 1)
            {
                btnSearch.PerformClick();
                return;
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCustomers.CurrentRow.Selected = true;
        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedCustomer = dgvCustomers.Rows[e.RowIndex].DataBoundItem as Customer;
                if (selectedCustomer != null)
                {
                    Main parent = this.MdiParent as Main;
                    if (parent != null)
                    {
                        parent.OpenForm(ref parent.customerDetailForm,
                            (s, ev) => parent.CloseForm(ref parent.customerDetailForm, s, ev));
                        parent.customerDetailForm.LoadCustomer(selectedCustomer);
                    }
                }
            }
        }
    }
}
