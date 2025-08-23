using kiosko_ssms.Data;
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

        public List<Data.Entities.Product> GetAllProducts()
        {
            return dbContext.Products.Where(p => !p.IsDeleted).OrderBy(p => p.Name).ToList();
        }
    }
}
