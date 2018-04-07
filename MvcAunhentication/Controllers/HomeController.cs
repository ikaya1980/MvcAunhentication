using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcAunhentication.Log;

namespace MvcAunhentication.Controllers
{
    public class HomeController : Controller
    {
        [Log]
        public ActionResult Index()
        {
            throw new ArgumentException("Hata fırlatıldı.");

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
    }
}