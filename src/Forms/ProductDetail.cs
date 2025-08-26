using kiosko_ssms.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiosko_ssms.Forms
{
    public partial class ProductDetail : Krypton.Toolkit.KryptonForm
    {
        private Product _product;
        public ProductDetail()
        {
            InitializeComponent();
        }

        public void LoadProduct(Product product)
        {
            var cultureInfo = new CultureInfo("es-PE");
            _product = product;
            txtId.Text = _product.Id.ToString();
            txtBarcode.Text = _product.Barcode;
            txtName.Text = _product.Name.ToUpper();
            txtDescription.Text = _product.Description.ToUpper();
            txtBuyPrice.Text = _product.BuyPrice.ToString("c", cultureInfo);
            txtSellPrice.Text = _product.SellPrice.ToString("c", cultureInfo);
            txtIsVisible.Text = _product.IsVisible ? "VISIBLE" : "NO VISIBLE";
            txtIsDeleted.Text = _product.IsDeleted ? "ELIMINADO" : "NO ELIMINADO";
            txtCreatedAt.Text = _product.CreatedAt.ToString("g");
            txtUpdatedAt.Text = _product.UpdatedAt.ToString("g");
            txtSupplier.Text = _product.Supplier != null ? _product.Supplier.Name.ToUpper() : "SIN PROVEEDOR";
            txtPresentation.Text = _product.Presentation != null ? _product.Presentation.Name.ToUpper() : "SIN PRESENTACIÓN";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
