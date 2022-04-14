using CourseWebAPI.Models;
using CourseWebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly IRepo<int, Course> _repo;

        public CourseController(IRepo<int, Course> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("All")]
        public async Task<ActionResult<List<Course>>> GetAll()
        {
            var courses = await _repo.GetAll();
            return Ok(courses);
        }
        [HttpGet]
        [Route("GetById/{id}")]

        public async Task<ActionResult<Course>> Get(int id)
        {
            var course = await _repo.Get(id);
            if (course == null)
                return NotFound("No course with ID " + id + " is found");
            return Ok(course);
        }

        //[HttpPut]
        //[Route("Update")]
        //public async Task<ActionResult<Course>> Update(int id, Course course)
        //{
        //    var updateCourse = await _repo.Update(course);
        //    if (updateCourse == null)
        //        return BadRequest("Please input the correct parameters");
        //    return Ok(updateCourse);
        //}

        //[HttpPost]
        //[Route("Add")]
        //public async Task<ActionResult<Course>> Create(Course course)
        //{
        //    var createCourse = await _repo.Add(course);
        //    if (createCourse == null)
        //        return BadRequest("Please input the correct parameters");
        //    return Ok(createCourse);
        //}

        //[HttpDelete]
        //[Route("Delete")]
        //public async Task<ActionResult> Delete(int id)
        //{
        //    var deleteCourse = await _repo.Delete(id);
        //    if (deleteCourse == null)
        //        return BadRequest("Please input the correct parameters");
        //    return Ok(deleteCourse);
        //}
    }
}
