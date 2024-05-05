
using Fiorello.Data;
using Fiorello.Models;
using Fiorello.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiorello.Controllers
{
    public class HomeController : Controller
    {
        public readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            List<Surprize> surprizes = await _context.Surprizes.ToListAsync();
            List<SurprizeList> surprizeLists = await _context.SurprizeLists.ToListAsync();
            List<Expert> experts = await _context.Experts.Include(m => m.Positions).ToListAsync();

            HomeVM models = new()
            {

                Surprizes = surprizes,
                SurprizeLists = surprizeLists,
                Experts = experts
            };
            return View(models);
        }

    }
}