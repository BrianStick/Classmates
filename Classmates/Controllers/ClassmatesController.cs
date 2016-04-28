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
                new ClassMate( "Zach ", "Blonde", 5.4),
                new ClassMate( "Trey", "Black", 5.2),
                new ClassMate( "Kate", "Brown", 5.2),
                new ClassMate( "Tee", "Brown", 5.9),
                new ClassMate( "Kevin", "Black", 5.5),
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