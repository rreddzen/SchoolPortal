using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPortal.Models
{
    [Table("StudentsInfo")]
    public class StudentInfo
    {
        [ForeignKey("Student")]
        public int Id { get; set; }

        public string Sex { get; set; }

        public int Age { get; set; }

        public string ContactNumber { get; set; }

        public Student Student { get; set; }

    }
}