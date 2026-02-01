using System;
using System.Collections.Generic;
using System.Web.Mvc;
using TourismManagementSystem.Models;

namespace TourismManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BrowseTours()
        {
            var tours = db.TourPackages.Where(t => t.IsActive).ToList();
            return View(tours);
        }

        public ActionResult TourDetails(int id)
        {
            var tour = db.TourPackages.FirstOrDefault(t => t.PackageId == id);
            if (tour == null)
                return HttpNotFound();
            return View(tour);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
