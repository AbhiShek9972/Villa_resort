using Microsoft.AspNetCore.Mvc;
using Villa_resort.Infrastructure.Data;
using Villa_resort.Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Villa_resort.Controllers
{
    public class VillaController : Controller
    {
        private readonly ApplicationDbContext _db;
        public VillaController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var villas = _db.Villas.ToList();
            return View(villas);
        }
        public IActionResult CreateVilla()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateVilla(VillaModel obj)
        {
            if (obj.Name == obj.Description)
            {
                ModelState.AddModelError("name", "The Name and Description cannot be the same.");
            }

            if (ModelState.IsValid)
            {
                _db.Villas.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();

        }

        public IActionResult Update(int VillaId)
        {
            VillaModel? obj = _db.Villas.FirstOrDefault(u => u.Id == VillaId);
            // var villa = _db.Villas.Find(VillaId);
            //var villaList = _db.Villas.Where(u => u.Price > 50 && u.Occupancy > 0).FirstOrDefault();
            if (obj == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Update(VillaModel obj)
        {
            //if (obj.Name == obj.Description)
            //{
            //    ModelState.AddModelError("name", "The Name and Description cannot be the same.");
            //}

            if (ModelState.IsValid)
            {
                _db.Villas.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();

        }

    }
}
