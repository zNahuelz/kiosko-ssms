using kiosko_ssms.Data.Entities;

namespace kiosko_ssms.Data.Helpers
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Amount { get; set; }
        public decimal Cost { get; set; }
        public double Tax { get; set; }
        public string ProductName => Product?.Name;
        public string PresentationName => Product?.Presentation.Name;
        public string Barcode => Product?.Barcode;
        public double Subtotal => (double)(Amount * Cost);
    }
}
