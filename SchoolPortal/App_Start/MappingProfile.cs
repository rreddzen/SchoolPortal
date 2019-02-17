using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AutoMapper;
using SchoolPortal.Models;
using SchoolPortal.ViewModel.CourseViewModel;


namespace SchoolPortal.App_Start
{
    public class MappingProfile
    {
        public MappingProfile()
        {
            Mapper.Initialize(
                cfg => {
                    cfg.CreateMap<AddCourseViewModel, Course>();

                });
        }
    }
}