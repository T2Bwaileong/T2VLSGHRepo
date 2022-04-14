using System.ComponentModel.DataAnnotations;

namespace CourseWebAPI.Models
{
    public class Student
    {
        [Key]
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public byte[] PassKey { get; set; }
    }
}
