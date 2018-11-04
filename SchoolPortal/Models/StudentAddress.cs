using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPortal.Models
{
    [Table("StudentsAddress")]
    public class StudentAddress
    {
        [ForeignKey("Student")]
        public int Id { get; set; }

        public string HouseNumber { get; set; }

        public string Street { get; set; }

        public string Barangay { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public int Zipcode { get; set; }

        public Student Student { get; set; }
    }
}