using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiosko_ssms.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Barcode { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public int Stock { get; set; }
        public int StockMin { get; set; }
        public bool IsVisible { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        //Relationships
        public int PresentationId { get; set; }
        public int SupplierId { get; set; }
        public Presentation Presentation { get; set; }
        public Supplier Supplier { get; set; }

    }
}
