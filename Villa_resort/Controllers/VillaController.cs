using Microsoft.AspNetCore.Mvc;
using Villa_resort.Infrastructure.Data;
using Villa_resort.Domain.Entities;

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
            _db.Villas.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
