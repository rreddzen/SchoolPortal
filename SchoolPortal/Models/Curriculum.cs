using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPortal.Models
{
    [Table("CourseCurriculums")]
    public class CourseCurriculum
    {
        public int Id { get; set; }
        public string CurriculumName { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }

        [ForeignKey("Year")]
        public int YearId { get; set; }

        [ForeignKey("Semester")]
        public int SemesterId { get; set; }

        [ForeignKey("Subject")]
        public int SubjectId { get; set; }

        public Course Course { get; set; }
        public YearLevel Year { get; set; }
        public Semester Semester { get; set; }
        public Subject Subject { get; set; }
    }

}
