using System;

namespace kiosko_ssms.Data.Entities
{
    public class Voucher
    {
        public int Id { get; set; }
        public double Igv { get; set; }
        public double Tax { get; set; }
        public double Subtotal { get; set; }
        public double Total { get; set; }
        public double Change { get; set; }
        public bool Paid { get; set; }
        public string Set { get; set; }
        public string Correlative { get; set; }
        public string PaymentSerial { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        //Relationships
        public int CustomerId { get; set; }
        public int VoucherTypeId { get; set; }
        public int PaymentTypeId { get; set; }
        public Customer Customer { get; set; }
        public VoucherType VoucherType { get; set; }
        public PaymentType PaymentType { get; set; }
    }
}
