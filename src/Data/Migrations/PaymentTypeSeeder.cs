using kiosko_ssms.Data.Entities;
using System;
using System.Collections.Generic;

namespace kiosko_ssms.Data.Migrations
{
    public class PaymentTypeSeeder
    {
        public List<PaymentType> PaymentTypes { get; } = new List<PaymentType>
        {
            new PaymentType {Id = 1, Name = "EFECTIVO", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsDeleted = false },
            new PaymentType {Id = 2, Name = "TARJETA DE DÉBITO", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsDeleted = false },
            new PaymentType {Id = 3, Name = "TARJETA DE CRÉDITO", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsDeleted = false },
            new PaymentType {Id = 4, Name = "YAPE", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsDeleted = false },
            new PaymentType {Id = 5, Name = "PLIN", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsDeleted = false },
        };
    }
}
