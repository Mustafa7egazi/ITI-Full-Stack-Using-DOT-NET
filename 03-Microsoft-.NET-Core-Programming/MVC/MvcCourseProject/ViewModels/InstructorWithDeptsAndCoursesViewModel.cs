using MvcCourseProject.Models.DBModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MvcCourseProject.ViewModels
{
    public class InstructorWithDeptsAndCoursesViewModel
    {
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Img { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; set; }
        public List<Department> DepartmentsList { get; set; }
        public int Crs_id { get; set; }
        public List<Course> CoursesList { get; set; }
    }
}
