using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        OdeToFoodDb _db = new OdeToFoodDb();

        public ActionResult Index(string searchTerm = null)
        {
            //var model = from r in _db.Restaurants
            //                //orderby r.Name ascending
            //                //orderby r.Reviews.Count descending
            //            orderby r.Reviews.Average(review => review.Rating) descending
            //            //select r;
            //            select new RestaurantListViewModel {
            //                Id = r.Id,
            //                Name = r.Name,
            //                City = r.City,
            //                Country = r.Country,
            //                ReviewCount = r.Reviews.Count(),
            //            };

            var model = _db.Restaurants
                .OrderByDescending(r => r.Reviews.Average(review => review.Rating))
                .Where(r=>searchTerm==null || r.Name.StartsWith(searchTerm) )
                .Select(r => new RestaurantListViewModel {
                    Id = r.Id,
                    Name = r.Name,
                    City = r.City,
                    Country = r.Country,
                    ReviewCount = r.Reviews.Count(),
                });

            return View(model);
        }

        public ActionResult About()
        {
            var model = new AboutModel {
                Name = "Matt",
                Location = "Dublin, IE",
            };
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if(_db != null)
                _db.Dispose();

            base.Dispose(disposing);
        }
    }
}