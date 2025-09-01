using kiosko_ssms.Data.Entities;
using System;
using System.Collections.Generic;

namespace kiosko_ssms.Data.Migrations
{
    public class ProductSeeder
    {
        public List<Product> Products { get; } = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "CLAVO ACERADO 1/2",
                BuyPrice = 3.2m,
                SellPrice = 4.5m,
                Stock = 50,
                StockMin = 50,
                SupplierId = 1,
                PresentationId = 9,
                Barcode = "0000000001234",
                IsVisible = true,
                IsDeleted = false,
                Description = "",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Product
            {
                Id = 2,
                Name = "CEMENTO SOL",
                BuyPrice = 20m,
                SellPrice = 35m,
                Stock = 120,
                StockMin = 100,
                SupplierId = 2,
                PresentationId = 3,
                Barcode = "0000000001237",
                IsVisible = true,
                IsDeleted = false,
                Description = "",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Product
            {
                Id = 3,
                Name = "CEMENTO ANDINO",
                BuyPrice = 19m,
                SellPrice = 30m,
                Stock = 80,
                StockMin = 100,
                SupplierId = 1,
                PresentationId = 3,
                Barcode = "0000000001236",
                IsVisible = true,
                IsDeleted = false,
                Description = "",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Product
            {
                Id = 4,
                Name = "BARRA DE CONSTRUCCIÓN SP 1/2\" x 9MTS",
                BuyPrice = 38m,
                SellPrice = 42.5m,
                Stock = 50,
                StockMin = 50,
                SupplierId = 2,
                PresentationId = 1,
                Barcode = "0000000001235",
                IsVisible = true,
                IsDeleted = false,
                Description = "",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Product
            {
                Id = 5,
                Name = "BARRA DE CONSTRUCCIÓN SP 6MM x 9MTS",
                BuyPrice = 15m,
                SellPrice = 30m,
                Stock = 50,
                StockMin = 50,
                SupplierId = 1,
                PresentationId = 1,
                Barcode = "0000000001233",
                IsVisible = true,
                IsDeleted = false,
                Description = "",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Product
            {
                Id = 6,
                Name = "BARRA DE CONSTRUCCIÓN SP 3/4\" x 9MTS",
                BuyPrice = 80m,
                SellPrice = 90m,
                Stock = 30,
                StockMin = 30,
                SupplierId = 2,
                PresentationId = 1,
                Barcode = "0000000001232",
                IsVisible = true,
                IsDeleted = false,
                Description = "",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Product
            {
                Id = 7,
                Name = "BARRA DE CONSTRUCCIÓN SP 12MM x 9MTS",
                BuyPrice = 30m,
                SellPrice = 37m,
                Stock = 25,
                StockMin = 30,
                SupplierId = 1,
                PresentationId = 1,
                Barcode = "0000000001231",
                IsVisible = true,
                IsDeleted = false,
                Description = "",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Product
            {
                Id = 8,
                Name = "ALAMBRE CORRUGADO 4.7MM x 8.80MTS",
                BuyPrice = 3m,
                SellPrice = 5.5m,
                Stock = 10,
                StockMin = 15,
                SupplierId = 2,
                PresentationId = 1,
                Barcode = "0000000001230",
                IsVisible = true,
                IsDeleted = false,
                Description = "",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            }
        };
    }
}
