﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolPortal.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Course
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}