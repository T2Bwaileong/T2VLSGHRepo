using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CourseWebAPI.Services;
using CourseWebAPI.Models;

namespace CourseWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudent _StudentRepo;

        public StudentController(IStudent studentRepo)
        {
            _StudentRepo = studentRepo;
        }

        [HttpPost]
        [Route("Login")]
        public ActionResult<StudentLoginDTO> Login(StudentLoginDTO student1)
        {
            var resultStudent = _StudentRepo.Login(student1);
            if (resultStudent != null)
                return Ok(resultStudent);
            student1.Password = "";
            return Unauthorized(student1);
        }

        [HttpPost]
        [Route("Register")]
        public ActionResult<StudentLoginDTO> Register(StudentDTO student)
        {
            var resultStudent = _StudentRepo.Register(student);
            if (resultStudent != null)
                return Ok(resultStudent);
            student.Password = "";
            return BadRequest(student);
        }
    }
}
