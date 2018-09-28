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
        }

        [HttpGet]
        public ActionResult Search()
        {
            return Content("GET: Search!");
        }
    }
}