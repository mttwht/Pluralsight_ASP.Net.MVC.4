using OdeToFood.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        //[Authorize]
        [Log]
        public ActionResult Search(string name = "French")
        {
            throw new Exception("OH NO!");

            var message = Server.HtmlEncode(name);

            return Content(message);
        }
    }
}