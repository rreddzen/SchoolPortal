using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MySql.Data.Entity;

namespace SchoolPortal.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.


    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

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
        {
        }

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