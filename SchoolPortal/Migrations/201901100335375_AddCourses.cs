namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourses : DbMigration
    {
        public override void Up()
        {

            Sql(@"INSERT INTO Courses (Id, CourseName, Description) 
                    VALUES (0, 'Bachelor of Science in Computer Engineering (BS CpE)', 'A five-year degree program that will train you in the design, development, and maintenance of computer systems including both hardware and software.')");


            Sql(@"INSERT INTO Courses (Id, CourseName, Description)
                    VALUES (0, 'Bachelor of Science in Electronics Engineering (BS ECE)', 'A five-year degree program in the Philippines that is mainly concerned with the conceptualization, design and development of any electronic, computer or communication products, systems, services and processes.')");
        }
        
        public override void Down()
        {
        }
    }
}
