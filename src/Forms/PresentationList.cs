using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using kiosko_ssms.Services;
using kiosko_ssms.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class PresentationList : Krypton.Toolkit.KryptonForm
    {
        private List<Presentation> presentations = new List<Presentation>();
        private string lastSearchMode = "";

        public PresentationList()
        {
            InitializeComponent();
        }

        private void PresentationList_Load(object sender, EventArgs e)
        {
            FillVisibilityOptions();
            FillSearchModes();
            FillPresentationTable();
            txtSearch.Focus();
        }

        private void ConfigureTable(DataGridView dgv)
        {
            dgv.Columns[0].HeaderText = "#";
            dgv.Columns[1].HeaderText = "NOMBRE";
            dgv.Columns[2].HeaderText = "CANTIDAD";
            dgv.Columns[3].HeaderText = "UNIDAD";
            dgv.Columns[4].HeaderText = "¿ELIMINADO?";
            dgv.Columns[5].HeaderText = "CREACIÓN";
            dgv.Columns[6].HeaderText = "ULT. MOD.";

            dgv.Columns[0].Width = 50;
            dgv.Columns[1].Width = 150;
            dgv.Columns[2].Width = 150;
            dgv.Columns[3].Width = 50;
            dgv.Columns[4].Width = 50;
            dgv.Columns[5].Width = 150;
            dgv.Columns[6].Width = 150;

        }

        private void FillPresentationTable(string mode = "")
        {
            try
            {
                bool showDeleted = cbVisibility.SelectedIndex == 0;
                switch (mode)
                {
                    case "BY_ID":
                        using (var context = new AppDbContext())
                        {
                            if (int.TryParse(txtSearch.Text?.Trim(), out int id))
                            {
                                presentations = new PresentationService(context).GetPresentationsById(id, showDeleted);
                                lastSearchMode = "BY_ID";
                            }
                            else
                            {
                                txtSearch.Clear();
                                MessageBox.Show("Ingrese un ID válido (número entero) para la búsqueda.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        break;
                    case "BY_NAME":
                        if (txtSearch.Text?.Trim().Length >= 3)
                        {
                            using (var context = new AppDbContext())
                            {
                                presentations = new PresentationService(context).GetPresentationsByName(txtSearch.Text.Trim().ToUpper(), showDeleted);

                            }
                            lastSearchMode = "BY_NAME";
                        }
                        break;
                    case "BY_UNIT":
                        if (txtSearch.Text?.Trim().Length >= 1)
                        {
                            using (var context = new AppDbContext())
                            {
                                presentations = new PresentationService(context).GetPresentationsByUnit(txtSearch.Text.Trim().ToUpper(), showDeleted);
                            }
                            lastSearchMode = "BY_UNIT";
                        }
                        break;
                    default:
                        using (var context = new AppDbContext())
                        {
                            presentations = new PresentationService(context).GetAllPresentations(showDeleted);
                        }
                        lastSearchMode = "";
                        break;
                }
                dgvPresentations.DataSource = presentations;
                ConfigureTable(dgvPresentations);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Constants.Messages.Error.DB_CONN_FAILED} {ex.Message}", Constants.Messages.Error.ERROR_TAG, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillVisibilityOptions()
        {
            cbVisibility.DataSource = Utils.Constants.VisibilityOptions;
        }

        private void FillSearchModes()
        {
            cbSearchMode.DataSource = Utils.Constants.PresentationSearchModes;
        }

        private void cbVisibility_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPresentationTable(lastSearchMode);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cbSearchMode.SelectedIndex)
            {
                case 0:
                    if (txtSearch.Text?.Trim().Length >= 1)
                    {
                        FillPresentationTable("BY_ID");
                    }
                    else
                    {
                        FillPresentationTable();
                    }
                    break;
                case 1:
                    if (txtSearch.Text?.Trim().Length >= 3)
                    {
                        FillPresentationTable("BY_NAME");
                    }
                    else
                    {
                        FillPresentationTable();
                    }
                    break;
                case 2:
                    if (txtSearch.Text?.Trim().Length >= 1)
                    {
                        FillPresentationTable("BY_UNIT");
                    }
                    else
                    {
                        FillPresentationTable();
                    }
                    break;
                default:
                    FillPresentationTable();
                    break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FillPresentationTable();
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

            if ((txtSearch.Text.Length >= 3 && (cbSearchMode.SelectedIndex == 1)) || (txtSearch.Text.Length >= 1 && cbSearchMode.SelectedIndex == 2))
            {
                btnSearch.PerformClick();
            }
        }

        private void dgvPresentations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPresentations.CurrentRow.Selected = true;
        }
    }
}
