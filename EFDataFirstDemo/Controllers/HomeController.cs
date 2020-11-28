using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFDataFirstDemo.Controllers
{
   
    public class HomeController : Controller
    {
        private EFCodeFirstDemo db = new EFCodeFirstDemo();


        public ActionResult Index()
        {
            var users = db.Users.ToList();
            var loginusers = db.LoginInfos.ToList();
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