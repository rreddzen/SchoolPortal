using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.Generic;

using SchoolPortal.Models;
namespace SchoolPortal.Controllers
{
    public class CoursesController : Controller
    {
        private ApplicationDbContext dbContext = new ApplicationDbContext();

        // GET: Course
        [HttpGet]
        public ActionResult Index()
        {
            var courses = dbContext.Courses.ToList();
            
            return View();
        }
    }
}