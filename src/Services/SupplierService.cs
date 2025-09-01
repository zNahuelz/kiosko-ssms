using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace kiosko_ssms.Services
{
    public class SupplierService
    {
        private readonly AppDbContext dbContext;

        public SupplierService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Supplier> GetAllSuppliers(bool showDeleted)
        {
            var suppliers = dbContext.Suppliers.Where(s => showDeleted ? s.IsDeleted : !s.IsDeleted).OrderBy(s => s.Name).ToList();
            return suppliers;
        }
    }
}
