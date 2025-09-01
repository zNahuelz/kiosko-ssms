using kiosko_ssms.Data.Entities;
using System;
using System.Collections.Generic;

namespace kiosko_ssms.Data.Migrations
{
    public class RoleSeeder
    {
        public List<Role> Roles { get; } = new List<Role>
        {
            new Role { Id = 1, Name = "GERENTE", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
            new Role { Id = 2, Name = "VENDEDOR", IsDeleted = false, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
        };
    }
}
