using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.Generic;

using SchoolPortal.Models;
using SchoolPortal.ViewModel.CourseViewModel;
using SchoolPortal.Services;
using AutoMapper;

namespace SchoolPortal.Controllers
{
    public class CoursesController : Controller
    {
        private ApplicationDbContext dbContext = new ApplicationDbContext();
        private readonly CoursesRepository courseRepository;

        public CoursesController()
        {
            courseRepository = new CoursesRepository(dbContext);
        }

        // GET: Course
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddCourse()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCourse(AddCourseViewModel viewModel)
        {
            if(!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var course = Mapper.Map<AddCourseViewModel, Course>(viewModel);
            courseRepository.Insert(course);
            courseRepository.SaveChanges();
            return RedirectToAction("Index", "Courses");
        }
    }
}