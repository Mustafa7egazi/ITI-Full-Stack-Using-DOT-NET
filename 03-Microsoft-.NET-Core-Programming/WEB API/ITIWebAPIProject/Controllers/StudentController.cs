using AutoMapper;
using ITIWebAPIProject.UnitOfWorks;
using ITIWebAPIProjectDay02.DTOs.StudentDTO;
using ITIWebAPIProjectDay02.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITIWebAPIProjectDay02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class StudentController : ControllerBase
    {
        private UnitOfWork unit;
        private IMapper mapper;

        public StudentController(UnitOfWork _unit, IMapper _mapper)
        {
            unit = _unit;
            mapper = _mapper;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(mapper.Map<List<DisplayStudentDTO>>(unit.StudentRepository.GetAll()));
        }

        [HttpGet("paged")]
        public IActionResult GetCustomStudents([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 5)
        {


            var studentDtos = mapper.Map<List<DisplayStudentDTO>>(unit.StudentRepository.GetCustomStudents(pageNumber, pageSize));

            var result = new
            {
                TotalCount = unit.StudentRepository.GetAll().Count(),
                PageNumber = pageNumber,
                PageSize = pageSize,
                Students = studentDtos
            };

            return Ok(result);
        }



        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            Student? s = unit.StudentRepository.GetById(id);
            if (s == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(mapper.Map<DisplayStudentDTO>(s));
            }
        }

        [HttpPost]
        public IActionResult AddStudent(AddStudentDTO addStudentDTO)
        {
            if (addStudentDTO == null) return BadRequest("Student data is required!");
            Student student = mapper.Map<Student>(addStudentDTO);
            unit.StudentRepository.Add(student);
            unit.Save();
            return CreatedAtAction(nameof(GetStudentById),
                new { id = student.StId },
                mapper.Map<AddStudentDTO>(student));

        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, AddStudentDTO addStudentDTO)
        {
            if (addStudentDTO == null) return BadRequest("Invalid student data!");
            Student? student = unit.StudentRepository.GetById(id);
            if (student == null) return NotFound("Student not found!");
            Student updatedStd = mapper.Map<Student>(addStudentDTO);
            student.StFname = updatedStd.StFname;
            student.StLname = updatedStd.StLname;
            student.StAddress = updatedStd.StAddress;
            student.StAge = updatedStd.StAge;
            student.DeptId = updatedStd.DeptId;
            student.StSuper = updatedStd.StSuper;
            unit.StudentRepository.Edit(student);
            unit.Save();

            return Ok(mapper.Map<AddStudentDTO>(student));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            Student? student = unit.StudentRepository.GetById(id);
            if (student == null) return NotFound("Student not found!");
            unit.StudentRepository.Delete(student);
            unit.Save();
            return NoContent();
        }
    }
}
