using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using System;
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

        public Supplier CreateSupplier(Supplier supplier)
        {
            supplier.Name = supplier?.Name?.Trim().ToUpper();
            supplier.Ruc = supplier?.Ruc?.Trim();
            supplier.Description = supplier?.Description?.Trim().ToUpper();
            supplier.Address = supplier?.Address?.Trim().ToUpper();
            supplier.PhoneNumber = supplier?.PhoneNumber?.Trim();
            supplier.Email = supplier?.Email?.Trim().ToUpper();
            supplier.IsDeleted = false;
            supplier.CreatedAt = DateTime.UtcNow;
            supplier.UpdatedAt = DateTime.UtcNow;
            bool rucExists = dbContext.Suppliers.Any(s => s.Ruc == supplier.Ruc && !s.IsDeleted);
            if (rucExists)
            {
                throw new System.InvalidOperationException("Ya existe un proveedor registrado con el RUC ingresado.");
            }
            dbContext.Suppliers.Add(supplier);
            dbContext.SaveChanges();
            return supplier;
        }

        public Supplier UpdateSupplier(Supplier supplier)
        {
            var existing = dbContext.Suppliers.Find(supplier.Id);
            if (existing == null)
            {
                throw new System.InvalidOperationException("El proveedor no existe o ha sido eliminado.");
            }
            existing.Name = supplier?.Name?.Trim().ToUpper();
            existing.Ruc = supplier?.Ruc?.Trim();
            existing.Description = supplier?.Description?.Trim().ToUpper();
            existing.Address = supplier?.Address?.Trim().ToUpper();
            existing.PhoneNumber = supplier?.PhoneNumber?.Trim();
            existing.Email = supplier?.Email?.Trim().ToUpper();
            existing.IsDeleted = supplier.IsDeleted;
            existing.UpdatedAt = DateTime.UtcNow;
            bool rucExists = dbContext.Suppliers.Any(s => s.Ruc == supplier.Ruc && s.Id != supplier.Id);
            if (rucExists)
            {
                throw new System.InvalidOperationException("Ya existe un proveedor registrado con el RUC ingresado.");
            }
            dbContext.SaveChanges();
            return existing;
        }
    }
}
