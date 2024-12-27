using eticaret_uygulamai.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace eticaret_uygulamai.Component
{
    public class SliderList : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public SliderList(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var result = _context.Slider.ToList();
            return View(result);
        }
    }
}
