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
        Name = "Unidad",
        Quantity = 1,
        Unit = "Uni.",
        IsDeleted = false,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
},
    new Presentation
    {
        Id = 2,
        Name = "Bolsa",
        Quantity = 1,
        Unit = "Kg.",
        IsDeleted = false,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    },
    new Presentation
    {
        Id = 3,
        Name = "Bolsa",
        Quantity = 42.5,
        Unit = "Kg.",
        IsDeleted = false,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    },
    new Presentation
    {
        Id = 4,
        Name = "Bolsa",
        Quantity = 2,
        Unit = "Kg.",
        IsDeleted = false,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    },
    new Presentation
    {
        Id = 5,
        Name = "Bolsa",
        Quantity = 0.5,
        Unit = "Kg.",
        IsDeleted = false,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    },
    new Presentation
    {
        Id = 6,
        Name = "Balde",
        Quantity = 5,
        Unit = "Kg.",
        IsDeleted = false,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    },
    new Presentation
    {
        Id = 7,
        Name = "Balde",
        Quantity = 2.5,
        Unit = "Kg.",
        IsDeleted = false,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    },
    new Presentation
    {
        Id = 8,
        Name = "Paquete",
        Quantity = 1000,
        Unit = "Uni.",
        IsDeleted = false,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    },
    new Presentation
    {
        Id = 9,
        Name = "Paquete",
        Quantity = 500,
        Unit = "Uni.",
        IsDeleted = false,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    },
    new Presentation
    {
        Id = 10,
        Name = "Rollo",
        Quantity = 100,
        Unit = "Mts.",
        IsDeleted = false,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    }
};
    }

}
