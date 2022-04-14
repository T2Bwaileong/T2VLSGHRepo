using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWebAPI.Models
{
    public class Certificate
    {
        //public int certificateId { get; set; }
        public string Date { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }


    }
}
