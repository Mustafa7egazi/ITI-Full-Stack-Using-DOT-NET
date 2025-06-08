using AutoMapper;
using ITIWebAPIProject.UnitOfWorks;
using ITIWebAPIProjectDay02.Data;
using ITIWebAPIProjectDay02.DTOs.DepartmentDTO;
using ITIWebAPIProjectDay02.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace ITIWebAPIProjectDay02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class DepartmentController : ControllerBase
    {
        private UnitOfWork unit;
        private readonly IMapper mapper;
        public DepartmentController(UnitOfWork _unit , IMapper _mapper)
        {
           unit = _unit;
            mapper = _mapper;
        }

        [HttpGet]
        public IActionResult GetAllDepartments()
        {
            return Ok(mapper.Map<List<DisplayDepartmentDTO>>(unit.DepartmentRepository.GetAll()));
        }

        [HttpGet("paged")]
        public IActionResult GetCustomDepartments([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 5)
        {
           

            var departmentDtos = mapper.Map<List<DisplayDepartmentDTO>>(unit.DepartmentRepository.GetCustomDepartments(pageNumber , pageSize));

            var result = new
            {
                TotalCount = unit.DepartmentRepository.GetAll().Count(),
                PageNumber = pageNumber,
                PageSize = pageSize,
                Departments = departmentDtos
            };

            return Ok(result);
        }



        [HttpGet("{id}")]
        public IActionResult GetDepartmentById(int id)
        {
            Department? department = unit.DepartmentRepository.GetById(id);
            if (department == null)
            {
                return NotFound("Department not found!");
            }
            else
            {
                return Ok(mapper.Map<DisplayDepartmentDTO>(department));
            }
        }


        [HttpGet("{name:alpha}")]
        public IActionResult GetDepartmentsByName(string name)
        {
            List<Department> departments = unit.DepartmentRepository.GetByName(name);
            if (departments.IsNullOrEmpty())
            {
                return NotFound("Department mismatch!");
            }
            else
            {
                return Ok(mapper.Map<List<DisplayDepartmentDTO>>(departments));
            }
        }



        [HttpPost]
        public IActionResult AddDepartment(AddDepartmentDTO addDepartmentDTO)
        {
            if(addDepartmentDTO == null) return BadRequest("Department data is required!");
            Department department = mapper.Map<Department>(addDepartmentDTO);
            unit.DepartmentRepository.Add(department);
            unit.Save();
            return CreatedAtAction(nameof(GetDepartmentById), new { id = department.DeptId }, mapper.Map<DisplayDepartmentDTO>(department));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDepartment(int id , AddDepartmentDTO addDepartmentDTO)
        {
            if (addDepartmentDTO == null)
                return BadRequest("Invalid department data!");

            Department? department = unit.DepartmentRepository.GetById(id);
            if (department == null)
                return NotFound("Department not found!");

            Department updatedDept = mapper.Map<Department>(addDepartmentDTO);
            department.DeptName = updatedDept.DeptName;
            department.DeptDesc = updatedDept.DeptDesc;
            department.DeptLocation = updatedDept.DeptLocation;
            department.DeptManager = updatedDept.DeptManager;
            department.ManagerHiredate = updatedDept.ManagerHiredate;

            unit.DepartmentRepository.Edit(department);
            unit.Save();
            return Ok(mapper.Map<DisplayDepartmentDTO>(department));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDepartment(int id)
        {
            Department? department = unit.DepartmentRepository.GetById(id);
            if (department == null)
            {
                return NotFound("Department not found!");
            }
            unit.DepartmentRepository.Delete(department);
            unit.Save();
            return NoContent();
        }
    }
}
