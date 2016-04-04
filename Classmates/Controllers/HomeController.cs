using Classmates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Classmates.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()

        {
            List<ClassMate> colleagues = new List<ClassMate>()
            {
                new ClassMate( "Brian", "Black", 5.5),
                new ClassMate( "Seth", "Black", 5.11),
                new ClassMate( "Zach ", "White", 5.4),
                new ClassMate( "Trey", "White", 5.2),
                new ClassMate( "Kate", "White", 5.2),
                new ClassMate( "Tee", "Black", 5.3),
                new ClassMate( "Kevin", "Asian", 5.1),
            };
            return View(colleagues);
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