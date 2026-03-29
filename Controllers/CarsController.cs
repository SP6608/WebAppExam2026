using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppAdvance.Data;
using WebAppAdvance.Models;
using WebAppAdvance.ModelsView;

namespace WebAppAdvance.Controllers
{
    public class CarsController : Controller
    {
        private readonly ApplicationDbContext dbcontext;

        public CarsController(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            EditCarViewModel? model = await dbcontext.Cars
                .AsNoTracking()
                .Where(c => c.Id == id)
                .Select(c => new EditCarViewModel
                {
                    Id = c.Id,
                    Brand = c.Brand,
                    Model = c.Model,
                    Year = c.Year,
                    Pasengers = c.Pasengers,
                    PricePerDay = c.PricePerDay
                })
                .FirstOrDefaultAsync();

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditCarViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Car? car = await dbcontext.Cars.FindAsync(model.Id);

            if (car == null)
            {
                return NotFound();
            }

            car.Brand = model.Brand;
            car.Model = model.Model;
            car.Year = model.Year;
            car.Pasengers = model.Pasengers;
            car.PricePerDay = model.PricePerDay;

            await dbcontext.SaveChangesAsync();

            return RedirectToAction("Details", new { id = car.Id });
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            DetailsViewModel? model = dbcontext
                .Cars
                .AsNoTracking()
                .Where(car => car.Id == id)
                .Select(car => new DetailsViewModel
                {
                    Id = car.Id,
                    Brand = car.Brand,
                    Model = car.Model,
                    Year = car.Year,
                    Pasengers = car.Pasengers,
                    PricePerDay = car.PricePerDay
                })
                .FirstOrDefault();

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }
    }
}