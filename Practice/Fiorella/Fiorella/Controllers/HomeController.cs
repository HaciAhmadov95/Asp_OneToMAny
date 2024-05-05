using Fiorella.Data;
using Fiorella.Models;
using Fiorella.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiorella.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            SliderInfo sliderInfos = await _context.SlidersInfo.FirstOrDefaultAsync();
            List<Category> categories = await _context.Categories.Take(4).ToListAsync();
            List<Product> products = await _context.Products.Include(m => m.ProductImages).ToListAsync();

            HomeVM model = new()
            {
                Sliders = sliders,
                SliderInfo = sliderInfos,
                Categories = categories,
                Products = products


            };

            return View(model);
        }
    }
}