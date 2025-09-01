using System;
using System.Collections.Generic;

namespace kiosko_ssms.Data.Entities
{
    public class Presentation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        //Relationships
        public List<Product> Products { get; set; } = new List<Product>();

        public override string ToString()
        {
            return $"{Name} {Quantity} {Unit}";
        }
    }
}
