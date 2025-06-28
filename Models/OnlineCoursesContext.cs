using Microsoft.EntityFrameworkCore;

namespace project.Models
{
    public class OnlineCoursesContext : DbContext
    {
        public OnlineCoursesContext(DbContextOptions<OnlineCoursesContext> options) : base(options)

        { }
        // we use this in table queries : 
        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        //intial values to course and student tables 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Course>().HasData(

            new Course { CourseId = 1, CourseName = "C++", CousrePrice = 150 },

            new Course { CourseId = 2, CourseName = "front end ", CousrePrice = 60 },

            new Course { CourseId = 3, CourseName = "Math", CousrePrice = 80 },

            new Course { CourseId = 4, CourseName = "Web Programming", CousrePrice = 300 },

            new Course { CourseId = 5, CourseName = "Embeded System", CousrePrice = 190 },

            new Course { CourseId = 6, CourseName = "Java", CousrePrice = 160 },

            new Course { CourseId = 7, CourseName = "Network Programming", CousrePrice = 90 },

            new Course { CourseId = 8, CourseName = "Lenux", CousrePrice = 90 },

            new Course { CourseId = 9, CourseName = "Python", CousrePrice = 130 },

            new Course { CourseId = 10, CourseName = "Project Managment", CousrePrice = 110 }

            );

            modelBuilder.Entity<Student>().HasData(
            new Student
            {
                StudentId = 1,
                Name = "maha",
                Average = 92,
                Password = "123",
                CourseId = 1
            },
            new Student
            {
                StudentId = 2,
                Name = "mohammed",
                Average = 99,
                Password = "212",
                CourseId = 1
            },
            new Student
            {
                StudentId = 3,
                Name = "shahd",
                Average = 97,
                Password = "262",
                CourseId = 6
            },
            new Student
            {
                StudentId = 4,
                Name = "suha",
                Average = 89,
                Password = "762",
                CourseId = 4
            },
            new Student
            {
                StudentId = 5,
                Name = "Rawan",
                Average = 97,
                Password = "292",
                CourseId = 7
            },
            new Student
            {
                StudentId = 6,
                Name = "Noor",
                Average = 74,
                Password = "202",
                CourseId = 2
            },
            new Student
            {
                StudentId = 7,
                Name = "Raghad",
                Average = 97,
                Password = "202",
                CourseId = 3
            },
            new Student
            {
                StudentId = 8,
                Name = "bushra",
                Average = 67,
                Password = "162",
                CourseId = 3
            },
            new Student
            {
                StudentId = 9,
                Name = "misk",
                Average = 88,
                Password = "200",
                CourseId = 3
            },
            new Student
            {
                StudentId = 10,
                Name = "yazan",
                Average = 57,
                Password = "772",
                CourseId = 2
            },
             new Student
             {
                 StudentId = 11,
                 Name = "yara",
                 Average = 91,
                 Password = "777",
                 CourseId = 2
             }
        );
        }
    }
}
