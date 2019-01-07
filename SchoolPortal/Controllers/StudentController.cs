using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



using SchoolPortal.ViewModel.Students;

namespace SchoolPortal.Controllers
{

    [RoutePrefix("student")]
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet, Route("create")]
        public ActionResult Create()
        {

            return View();
        }



        [HttpPost, Route("create")]
        public ActionResult Create(CreateStudentViewModel viewModel)
        {

            return View();
        }


    }
}