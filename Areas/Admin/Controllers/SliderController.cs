using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultiShop.DataAccesLayer;
using MultiShop.Models;
using MultiShop.ViewModels.Sliders;

namespace MultiShop.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class SliderController (MultiShopContext _context): Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
          var data = await _context.Sliders.Select(s=>new GetSliderVM
            {
                Id = s.Id,
                Title = s.Title,
                Subtitle = s.Subtitle,
                ImageUrl = s.ImageUrl,
            }
            ).ToListAsync();

            return View(data ?? new List<GetSliderVM>());
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateSliderVM vm)
        {
            if (ModelState.IsValid)
            {
                return View(vm);
            }
            Slider slider = new Slider
            {
                Title = vm.Title,
                ImageUrl = vm.ImageUrl,
                Subtitle = vm.Subtitle,
                CreatedTime = DateTime.Now,
                IsDeleted = false,
            };
            await _context.AddAsync(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
