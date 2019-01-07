using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MySql.Data.Entity;

namespace SchoolPortal.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseCurriculum> CourseCurriculum { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<FacultyRole> FacultyRoles { get; set; }
        public DbSet<FacultyAddress> FacultyAddresses { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<YearLevel> YearLevels { get; set; }
        public DbSet<Department> Departments { get; set; }


        public ApplicationDbContext()
            : base("SchoolPortal", throwIfV1Schema: false)
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();

        }
    }
}