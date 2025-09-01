using System;
using System.Collections.Generic;

namespace kiosko_ssms.Data.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        //Relationships
        public List<User> Users { get; set; } = new List<User>();
    }
}
