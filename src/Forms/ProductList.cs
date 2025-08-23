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
    public partial class ProductList : Krypton.Toolkit.KryptonForm
    {
        public ProductList()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            try
            {
                List<Product> products = new List<Product>();
                var dbContext = new Data.AppDbContext();
                ProductService _productService = new ProductService(dbContext);
                products = _productService.GetAllProducts();
                dgvProducts.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
