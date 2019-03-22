using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HallOfFameMJ.Controllers
{
    public class HomeController : Controller
    {
        // test comment
        // test comment 2
        // test comment 3 - created a branch
        // test comment 4 - merge
        // test comment 5
        // test comment 6

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page!!!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}