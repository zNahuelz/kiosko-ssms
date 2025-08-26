using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiosko_ssms.Services
{
    public class ProductService
    {
        private readonly AppDbContext dbContext;

        public ProductService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Product> GetAllProducts(bool showDeleted)
        {
            var products = dbContext.Products.Include(p => p.Presentation).Include(p => p.Supplier).Where(p => showDeleted ? p.IsDeleted : !p.IsDeleted).OrderBy(p => p.Stock).ToList();
            return products;
        }

        public List<Product> GetProductsByName(string name)
        {
            var products = dbContext.Products.Include(p => p.Presentation).Include(p => p.Supplier).Where(p => p.Name.Contains(name.Trim().ToUpper()) && !p.IsDeleted).OrderBy(p => p.Name).ToList();
            return products;
        }

        public List<Product> GetProductsByBarcode(string barcode)
        {
            var products = dbContext.Products.Include(p => p.Presentation).Include(p => p.Supplier).Where(p => p.Barcode == barcode.Trim() && !p.IsDeleted).ToList();
            return products;
        }

        public List<Product> GetProductsBySupplier(int supplierId)
        {
            var products = dbContext.Products.Include(p => p.Presentation).Include(p => p.Supplier).Where(p => p.SupplierId == supplierId && !p.IsDeleted).OrderBy(p => p.Name).ToList();
            return products;
        }

        public List<Product> GetProductsByPresentation(int presentationId)
        {
            var products = dbContext.Products.Include(p => p.Presentation).Include(p => p.Supplier).Where(p => p.PresentationId == presentationId && !p.IsDeleted).OrderBy(p => p.Name).ToList();
            return products;
        }
    }
}
