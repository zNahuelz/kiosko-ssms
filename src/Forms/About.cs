using kiosko_ssms.Utils;
using System;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/zNahuelz");
            }
            catch (Exception) { MessageBox.Show(Constants.Messages.Info.NO_BROWSER_FOUND); }
        }
    }
}
