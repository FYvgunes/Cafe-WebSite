﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cafe_Web_Site_Themlate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [Route("Hakkimizda")]
        public ActionResult About()
        {
            return View();
        }
        [Route("Urunler")]
        public ActionResult Products()
        {
            return View();

        }
        [Route("magaza")]
        public ActionResult Store()
        {
            return View();

        }
    }
}