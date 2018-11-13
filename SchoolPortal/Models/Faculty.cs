using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPortal.Models
{
    [Table("Faculty")]
    public class Faculty
    {
        public int Id { get; set; }

        public string FacultyCode { get; set; }

        public string Photo { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Sex { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string EmailAddress { get; set; }

        public string MobileNumber { get; set; }


        // Navigation Properties
        public int RoleId { get; set; }
        public FacultyRole Role { get; set; }


    }
}
