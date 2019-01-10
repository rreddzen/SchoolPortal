using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolPortal.Models;
using SchoolPortal.Services.Reusables;

namespace SchoolPortal.Services
{
    public class CoursesRepository :  GenericRepository<ApplicationDbContext, Course>
    {
        public CoursesRepository(ApplicationDbContext _context) : base(_context)
        {

        }

    }
}