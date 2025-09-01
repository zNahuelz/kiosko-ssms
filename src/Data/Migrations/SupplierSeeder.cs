using kiosko_ssms.Data.Entities;
using System;
using System.Collections.Generic;

namespace kiosko_ssms.Data.Migrations
{
    public class SupplierSeeder
    {
        public List<Supplier> Suppliers { get; } = new List<Supplier>
        {
            new Supplier { Id = 1, Name = "ACEROS AREQUIPA", Ruc = "20370146994", Address = "Car. Panamericana Sur Nro. 241 Panamericana Sur", PhoneNumber = "994615443", Email = "VENTAS@ACEROS_AREQUIPA.COM", Description = "-----", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
            new Supplier { Id = 2, Name = "FERROPOLIS PE", Ruc = "20601968607", Address = "Mza. G Lote. 01 A.H. los Alamos de Ventanilla", PhoneNumber = "996192665", Email = "VENTAS@FERROPOLIS.NET", Description = "-----", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
        };
    }
}
