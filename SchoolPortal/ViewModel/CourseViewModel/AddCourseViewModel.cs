using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolPortal.ViewModel.CourseViewModel
{
    public class AddCourseViewModel
    {
        [Required, Display(Name ="Course Name :")]
        [RegularExpression(pattern: "^[_A-z0-9 ()]*((-|\\s)*[_A-z0-9 ()])*$", ErrorMessage ="No symbols are allowed in here.")]
        public string CourseName { get; set; }

        [Required, Display(Name = "Description :")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

    }
}