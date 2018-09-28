using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        [HttpPost]
        public ActionResult Search(string name = "French")
        {
            var message = Server.HtmlEncode(name);

            return Content(message);
            //return RedirectPermanent("google.ie");
            //return RedirectToAction("Index", "Home", new { name = name });
            //return RedirectToRoute("Default", new { controller="Home", action="about" });
            //return File(Server.MapPath("~/Content/Site.css"), "text/css");
            //return Json(new { message = message, name = "Matt" }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Search()
        {
            return Content("GET: Search!");
        }
    }
}