using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using kiosko_ssms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class NewProduct : Krypton.Toolkit.KryptonForm
    {
        private readonly AppDbContext DB_CONTEXT = new Data.AppDbContext();

        public NewProduct()
        {
            InitializeComponent();
        }

        private void btnRandomBarcode_Click(object sender, EventArgs e)
        {
            txtBarcode.Text = GenerateRandomBarcode();
        }

        private string GenerateRandomBarcode()
        {
            bool valid = false;
            string barcode = "";
            while (!valid)
            {
                barcode = BarcodeFactory();
                var products = new ProductService(DB_CONTEXT).GetProductsByBarcode(barcode);
                if (products.Count <= 0)
                {
                    valid = true;
                }
            }
            return barcode;
        }

        private string BarcodeFactory()
        {
            Random random = new Random();
            int value = random.Next(1, 100000);
            string barcode = value.ToString().PadLeft(13, '0');
            return barcode;
        }

    }
}
