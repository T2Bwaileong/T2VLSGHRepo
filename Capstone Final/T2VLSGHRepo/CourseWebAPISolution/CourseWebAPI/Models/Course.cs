using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWebAPI.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public float Cost { get; set; }
        public string Video { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        //[ForeignKey("authorId")]

    }
}
