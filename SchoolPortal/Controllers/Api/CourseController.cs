using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SchoolPortal.Models;
using SchoolPortal.Services;

namespace SchoolPortal.Controllers.Api
{
    [RoutePrefix("api/courses")]
    public class CourseController : ApiController
    {
        private CoursesRepository courseRepo = new CoursesRepository(new ApplicationDbContext());

        [HttpGet]
        [Route("all-courses")]
        public IHttpActionResult GetAllCourses()
        {
            return Ok(courseRepo.GetAll().ToList());
        }

        //[HttpPost]
        //public IHttpActionResult InsertCourse()
        //{

        //}

        //[HttpPut]
        //[Route("{id}")]
        //public IHttpActionResult UpdateCourse()
        //{

        //}

    }
}