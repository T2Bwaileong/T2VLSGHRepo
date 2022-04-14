using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWebAPI.Models
{
    public class StudentCourse
    {
        //public int studentcourseId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }




    }
}
