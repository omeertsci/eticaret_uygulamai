using eticaret_uygulamai.Data;
using eticaret_uygulamai.Dto;
using eticaret_uygulamai.Models;
using eticaret_uygulamai.Oturum;
using Microsoft.AspNetCore.Mvc;

namespace eticaret_uygulamai.Component
{
    public class CartSumList:ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public CartSumList(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart")?? new List<CartItem>();

            CartViewModel cartVm = new()
            {
                CartItems= cart,
                GrandTotal = cart.Sum(x => x.Quantity* x.Price)
            };
            return View(cartVm);
        }
    }
}
