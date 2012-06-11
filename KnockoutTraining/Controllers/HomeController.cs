using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnockoutTraining.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Basic()
        {
            return View();
        }

        public ActionResult Observable()
        {
            return View();
        }

        public ActionResult Computed()
        {
            return View();
        }

        public ActionResult Events()
        {
            return View();
        }

        public ActionResult Collections()
        {
            return View();
        }

        public ActionResult ComplexCollections()
        {
            return View();
        }

        public ActionResult Advanced()
        {
            return View();
        }
    }
}
