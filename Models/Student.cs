namespace project.Models
{
    public class Student
    {
        public int StudentId { set; get; }
        public string Name { set; get; }
        public double Average { set; get; }
        public string Password { set; get; }
        public int CourseId { set; get; }
        public Course Course { set; get; }
    }
}
