using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPortal.Models
{
    [Table("Courses")]
    public class Course
    {
        public int Id { get; set; }

        public string CourseName { get; set; }

        public string Description { get; set; }

    }
}
