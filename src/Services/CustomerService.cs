using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace kiosko_ssms.Services
{
    public class CustomerService
    {
        private readonly AppDbContext dbContext;

        public CustomerService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Customer> GetAllCustomers(bool showDeleted)
        {
            var customers = dbContext.Customers.Where(c => showDeleted || !c.IsDeleted).OrderBy(c => c.Names).ToList();
            return customers;
        }

        public List<Customer> GetCustomersByName(string name, bool showDeleted)
        {
            var customers = dbContext.Customers.Where(c => c.Names.Contains(name) && (showDeleted || !c.IsDeleted))
                .OrderBy(c => c.Names)
                .ToList();
            return customers;
        }

        public List<Customer> GetCustomersByDni(string dni, bool showDeleted)
        {
            var customers = dbContext.Customers
                .Where(c => c.Dni.Contains(dni) && (showDeleted || !c.IsDeleted))
                .OrderBy(c => c.Names)
                .ToList();
            return customers;
        }
    }
}
