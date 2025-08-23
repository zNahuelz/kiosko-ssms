using kiosko_ssms.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiosko_ssms.Data.Migrations
{
    public class UserSeeder
    {
        public List<User> Users { get; } = new List<User>
        {
            new User { Id = 1, Names = "JUAN", Surnames = "VARGAS", Dni = "01122345", PhoneNumber = "999888777", Address = "Av. Globo Terraqueo 777",Email = "admin@app.com", Password = BCrypt.Net.BCrypt.HashPassword("admin") , IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, RoleId=1 },
            new User { Id = 2, Names = "HECTOR", Surnames = "VARGAS", Dni = "01122115", PhoneNumber = "999888666", Address = "Av. Globo Terraqueo 666",Email = "seller@app.com", Password = BCrypt.Net.BCrypt.HashPassword("seller") , IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, RoleId=2 },
        };

    }
}
