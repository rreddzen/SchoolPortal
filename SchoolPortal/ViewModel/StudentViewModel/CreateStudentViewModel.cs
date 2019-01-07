using SchoolPortal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolPortal.ViewModel.Students
{

    public class CreateStudentViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; }

        public string Photo { get; set; }

        [Required]
        [Display(Name = "Firstname")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Middlename")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Lastname")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Date of birth")]
        public int DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Sex")]
        public string Sex { get; set; }

        [Required]
        [Display(Name = "Year level")]
        public byte YearLevel { get; set; }

        [Required]
        [Display(Name = "Email-address")]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "")]
        public string ContactNumber { get; set; }

        [Required]
        public StudentAddressViewModel Address { get; set; }


    }
}