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

        /// <summary>
        /// page d'acceuil
        /// </summary>
        /// <returns>vues</returns>
        [Authorize(Roles ="Admin,Auteurs")]
        public ActionResult Index()
        {
            GMailer.senMail("nfarah@groupeisi.com", "test", "Ce mail est un test");
            Util.WriteLogSystem("Home-Index", "Hello ! application run");
            this.Flash(ResourceFr.Welcome, Flashlevel.success);
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