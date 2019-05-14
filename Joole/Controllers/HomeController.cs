using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Joole.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Product Details Page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Compare Products Page.";

            return View();
        }
    }
}