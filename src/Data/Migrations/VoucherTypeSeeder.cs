using kiosko_ssms.Data.Entities;
using System;
using System.Collections.Generic;

namespace kiosko_ssms.Data.Migrations
{
    public class VoucherTypeSeeder
    {
        public List<VoucherType> VoucherTypes { get; } = new List<VoucherType>
        {
            new VoucherType{Id = 1, Name = "BOLETA", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsDeleted = false},
            new VoucherType{Id = 2, Name = "FACTURA", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsDeleted = false},
        };
    }
}
