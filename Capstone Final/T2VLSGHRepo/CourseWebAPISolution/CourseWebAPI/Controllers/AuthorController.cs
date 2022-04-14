using CourseWebAPI.Models;
using CourseWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IRepo<int, Author> _authorRepo;

        public AuthorController(IRepo<int, Author> repo)
        {
            _authorRepo = repo;
        }

        [HttpGet]
        [Route("All")]
        public async Task<ActionResult<List<Author>>> GetAll()
        {
            var authors = await _authorRepo.GetAll();
            return Ok(authors);
        }
        [HttpGet]
        [Route("GetById/{id}")]

        public async Task<ActionResult<Author>> Get(int id)
        {
            var author = await _authorRepo.Get(id);
            if (author == null)
                return NotFound("No author with ID " + id + " is found");
            return Ok(author);
        }
    }
}
