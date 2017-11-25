using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRProjectWeb.Models;

namespace HRProjectWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Nationality()
        {
            ViewBag.Message = "Nationalities";
            Nationality nat = new Nationality();            
            return View(nat.GetNationalityList());
        }
    }
}