﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HallOfFameMJ.Controllers
{
    public class HomeController : Controller
    {
        //test commit from local dev
        // test from dev2
        public ActionResult Index()
        {
            return View();
        }
        //test comment from local master
        // test from master 
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
