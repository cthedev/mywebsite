using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About me webpage.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact me webpage.";

            return View();
        }

        public ActionResult WorkHistory()
        {
            ViewBag.Message = "My work history.";

            return View(); 
        }

    }
}