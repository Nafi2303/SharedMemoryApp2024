using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcFoad2024_2.App_Start;
using MvcFoad2024_2.Models;

namespace MvcFoad2024_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            this.Flash(ResourceFr.welcome, Flashlevel.success);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = ResourceFr.APropos;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}