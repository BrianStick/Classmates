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
                new ClassMate( 1,"Brian", "Black", 5.5),
                new ClassMate( 2,"Seth", "Black", 5.11),
                new ClassMate( 3,"Zach ", "Blonde", 5.4),
                new ClassMate( 4,"Trey", "Black", 5.2),
                new ClassMate( 5,"Kate", "Brown", 5.2),
                new ClassMate(6, "Tee", "Brown", 5.9),
                new ClassMate( 7,"Kevin", "Black", 5.5),
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