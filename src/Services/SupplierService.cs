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
            var suppliers = dbContext.Suppliers.Where(s => showDeleted || !s.IsDeleted).OrderBy(s => s.Name).ToList();
            return suppliers;
        }

        public List<Supplier> GetSuppliersByName(string name, bool showDeleted)
        {
            var suppliers = dbContext.Suppliers
                .Where(s => s.Name.Contains(name) && (showDeleted || !s.IsDeleted))
                .OrderBy(s => s.Name)
                .ToList();
            return suppliers;
        }

        public List<Supplier> GetSuppliersByRUC(string ruc, bool showDeleted)
        {
            var suppliers = dbContext.Suppliers
                .Where(s => s.Ruc.Contains(ruc) && (showDeleted || !s.IsDeleted))
                .OrderBy(s => s.Name)
                .ToList();
            return suppliers;
        }
    }
}
