using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using System;
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

        public Customer CreateCustomer(Customer customer)
        {
            customer.Names = customer?.Names?.Trim().ToUpper();
            customer.Surnames = customer?.Surnames?.Trim().ToUpper();
            customer.Dni = customer?.Dni?.Trim();
            bool dniExists = dbContext.Customers.Any(c => c.Dni == customer.Dni);
            if (dniExists)
            {
                throw new InvalidOperationException("Ya existe un cliente registrado con el DNI ingresado.");
            }
            customer.PhoneNumber = customer?.PhoneNumber?.Trim();
            customer.Address = customer?.Address?.Trim().ToUpper();
            customer.Email = customer?.Email?.Trim().ToUpper();
            customer.IsDeleted = false;
            customer.CreatedAt = DateTime.UtcNow;
            customer.UpdatedAt = DateTime.UtcNow;

            dbContext.Customers.Add(customer);
            dbContext.SaveChanges();
            return customer;
        }

        public Customer UpdateCustomer(Customer customer)
        {
            var existing = dbContext.Customers.Find(customer.Id);
            if (existing == null)
            {
                throw new InvalidOperationException("El cliente que intenta actualizar no existe o ha sido eliminado.");
            }
            existing.Names = customer?.Names?.Trim().ToUpper();
            existing.Surnames = customer?.Surnames?.Trim().ToUpper();
            existing.Dni = customer?.Dni?.Trim();
            bool dniExists = dbContext.Customers.Any(c => c.Dni == existing.Dni && c.Id != existing.Id);
            if (dniExists)
            {
                throw new InvalidOperationException("Ya existe un cliente registrado con el DNI ingresado.");
            }
            existing.PhoneNumber = customer?.PhoneNumber?.Trim();
            existing.Address = customer?.Address?.Trim().ToUpper();
            existing.Email = customer?.Email?.Trim().ToUpper();
            existing.IsDeleted = customer.IsDeleted;
            existing.UpdatedAt = DateTime.UtcNow;

            dbContext.SaveChanges();
            return existing;
        }
    }
}
