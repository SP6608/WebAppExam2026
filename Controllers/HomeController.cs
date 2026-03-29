using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebAppAdvance.Data;
using WebAppAdvance.Models;
using WebAppAdvance.ModelsView;

namespace WebAppAdvance.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext dbcontext;
        public HomeController(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await dbcontext
                .Cars
                .AsNoTracking()
                .Select(m => new CarsIndexViewModel()
                {
                    Id = m.Id,
                    Brand = m.Brand,
                    Model = m.Model,
                    Year = m.Year,
                    Pasengers = m.Pasengers,
                    PricePerDay = m.PricePerDay
                }).ToListAsync();
            return View(model);
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
