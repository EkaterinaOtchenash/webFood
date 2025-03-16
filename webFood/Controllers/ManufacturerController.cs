using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webFood.Data;
using webFood.Models;

namespace webFood.Controllers
{
    public class ManufacturerController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ManufacturerController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: Manufacturer
        public IActionResult Index()
        {
            IEnumerable<Manufacturer> manufacturers = _db.Manufacturer;
            return View(manufacturers);
        }

        // GET: Manufacturer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Manufacturer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Manufacturer manufacturer)
        {
            if (ModelState.IsValid)
            {
                _db.Manufacturer.Add(manufacturer);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(manufacturer);
        }

        // GET: Manufacturer/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var manufacturer = _db.Manufacturer.Find(id);
            if (manufacturer == null)
            {
                return NotFound();
            }

            return View(manufacturer);
        }

        // POST: Manufacturer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Manufacturer manufacturer)
        {
            if (ModelState.IsValid)
            {
                _db.Manufacturer.Update(manufacturer);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(manufacturer);
        }

        // GET: Manufacturer/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var manufacturer = _db.Manufacturer.Find(id);
            if (manufacturer == null)
            {
                return NotFound();
            }

            return View(manufacturer);
        }

        // POST: Manufacturer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var manufacturer = _db.Manufacturer.Find(id);
            if (manufacturer == null)
            {
                return NotFound();
            }

            _db.Manufacturer.Remove(manufacturer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}