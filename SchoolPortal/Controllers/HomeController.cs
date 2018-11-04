using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.Generic;


using SchoolPortal.Models;

namespace SchoolPortal.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext context;

        public HomeController()
        {
            context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            return View();
        }

        [Route("/About")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";


            return View();
        }

        [Route("/Contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";


            return View();
        }
    }
}