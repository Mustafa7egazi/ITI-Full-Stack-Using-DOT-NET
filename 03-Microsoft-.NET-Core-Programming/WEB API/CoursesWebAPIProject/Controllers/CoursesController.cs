using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIProject.Models;
using WebAPIProject.Repository;

namespace WebAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseRepository CourseRepo;
        public CoursesController(ICourseRepository _courseRepo)
        {
            CourseRepo = _courseRepo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var courses = CourseRepo.Get();
            if (courses == null || !courses.Any())
            {
                return NotFound("No courses found.");
            }
            return Ok(courses);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var course = CourseRepo.GetById(id);
            if (course == null)
            {
                return NotFound($"Course with ID {id} not found.");
            }
            return Ok(course);
        }

        [HttpGet("{name:alpha}")]
        public IActionResult CourseByName(string name)
        {
            Course? course = CourseRepo.CourseByName(name);
            if (course == null)
            {
                return NotFound($"Course with name '{name}' not found.");
            }
            else
            {
                return Ok(course);
            }
        }


        [HttpPost]
        public IActionResult Post(Course c)
        {
            if (c == null)
            {
                return BadRequest("Course data is null.");
            }
            else
            {
                CourseRepo.Post(c);
                CourseRepo.Save();
                return CreatedAtAction(nameof(GetById), new { id = c.Id }, c);
            }
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id , Course c)
        {
            if( c == null || id != c.Id)
            {
                return BadRequest("Course data is null or ID mismatch.");
            }
            else
            {
                Course? course = CourseRepo.GetById(id);
                if (course == null)
                {
                    return NotFound($"Course with ID {id} not found.");
                }
                else
                {
                    CourseRepo.Put(id, c);
                    CourseRepo.Save();
                    return NoContent(); 
                }
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteCourse(int id)
        {
            Course? c = CourseRepo.GetById(id);
            if (c == null)
            {
                return NotFound($"Course with id {id} not found");
            }
            else
            {
                CourseRepo.DeleteCourse(id);
                CourseRepo.Save();
                return Ok(CourseRepo.Get()); 
            }
        }
    }
}
