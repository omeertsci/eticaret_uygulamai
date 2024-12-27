using eticaret_uygulamai.Models;

namespace eticaret_uygulamai.Dto
{
    public class CartViewModel
    {
        public List<CartItem> CartItems { get; set; }
        public decimal GrandTotal { get; set; }
    }
}
