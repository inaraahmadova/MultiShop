using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultiShop.DataAccesLayer;

namespace MultiShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly MultiShopContext _context;

        public HomeController (MultiShopContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Categories.ToListAsync();
            return View(data);
        }
        public async Task<IActionResult> Contact()
        {
            return View();
        }
    }
}
