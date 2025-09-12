using kiosko_ssms.Data.Entities;
using System;
using System.Collections.Generic;

namespace kiosko_ssms.Data.Migrations
{
    public class PresentationSeeder
    {
        public List<Presentation> Presentations { get; } = new List<Presentation>{
            new Presentation
    {
                Id = 1,
        Name = "UNIDAD",
        Quantity = 1,
        Unit = "UNI.",
        IsDeleted = false,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
},
    new Presentation
    {
        Id = 2,
        Name = "BOLSA",
        Quantity = 1,
        Unit = "KG.",
        IsDeleted = false,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    },
    new Presentation
    {
        Id = 3,
        Name = "BOLSA",
        Quantity = 42.5,
        Unit = "KG.",
        IsDeleted = false,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    },
    new Presentation
    {
        Id = 4,
        Name = "BOLSA",
        Quantity = 2,
        Unit = "KG.",
        IsDeleted = false,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    },
    new Presentation
    {
        Id = 5,
        Name = "BOLSA",
        Quantity = 0.5,
        Unit = "KG.",
        IsDeleted = false,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    },
    new Presentation
    {
        Id = 6,
        Name = "Balde",
        Quantity = 5,
        Unit = "KG.",
        IsDeleted = false,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    },
    new Presentation
    {
        Id = 7,
        Name = "Balde",
        Quantity = 2.5,
        Unit = "KG.",
        IsDeleted = false,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    },
    new Presentation
    {
        Id = 8,
        Name = "Paquete",
        Quantity = 1000,
        Unit = "UNI.",
        IsDeleted = false,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    },
    new Presentation
    {
        Id = 9,
        Name = "Paquete",
        Quantity = 500,
        Unit = "UNI.",
        IsDeleted = false,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    },
    new Presentation
    {
        Id = 10,
        Name = "Rollo",
        Quantity = 100,
        Unit = "MTS.",
        IsDeleted = false,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    }
};
    }

}
