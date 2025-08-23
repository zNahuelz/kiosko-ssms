using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiosko_ssms.Data.Entities
{
    public class VoucherDetail
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public double UnitPrice { get; set; }   
        public double Subtotal { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        //Relationships
        public int VoucherId { get; set; }
        public int ProductId { get; set; }
        public Voucher Voucher { get; set; }
        public Product Product { get; set; }    
    }
}
