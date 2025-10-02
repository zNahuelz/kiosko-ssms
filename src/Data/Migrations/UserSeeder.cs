using kiosko_ssms.Data.Entities;
using System;
using System.Collections.Generic;

namespace kiosko_ssms.Data.Migrations
{
    public class UserSeeder
    {
        public List<User> Users { get; } = new List<User>
        {
            new User { Id = 1, Names = "root", Surnames = "kiosko", Dni = "01111111", PhoneNumber = "000111000", Address = "---------",Email = "ROOT@KIOSKO.COM", Password = BCrypt.Net.BCrypt.HashPassword("r00to") , IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, RoleId=1 },
            new User { Id = 2, Names = "JUAN", Surnames = "VARGAS", Dni = "01122345", PhoneNumber = "999888777", Address = "Av. Globo Terraqueo 777",Email = "ADMIN@APP.COM", Password = BCrypt.Net.BCrypt.HashPassword("admin") , IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, RoleId=1 },
            new User { Id = 3, Names = "HECTOR", Surnames = "VARGAS", Dni = "01122115", PhoneNumber = "999888666", Address = "Av. Globo Terraqueo 666",Email = "SELLER@APP.COM", Password = BCrypt.Net.BCrypt.HashPassword("seller") , IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, RoleId=2 },
        };

    }
}
