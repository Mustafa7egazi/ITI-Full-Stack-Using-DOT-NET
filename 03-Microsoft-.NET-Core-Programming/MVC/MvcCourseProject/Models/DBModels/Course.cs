using Microsoft.AspNetCore.Mvc;
using MvcCourseProject.Models.CustomAttributes;
using MvcCourseProject.Repository;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCourseProject.Models.DBModels
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Course Name Is Required")]
        [MinLength(2, ErrorMessage = "Course Name Must be More Than 1 Char")]
        [MaxLength(25,ErrorMessage ="Name Length exceeds 25 character limit")]
        [Unique]
        public string Name { get; set; }
        [Range(50,100,ErrorMessage ="Degree must be between 50 and 100")]
        [Required(ErrorMessage = "Degree Is Required")]
        public int Degree { get; set; }
        
        //Get :/Course/CheckMinDegreeInRange?MinDegree=..
        [Remote("CheckMinDegreeInRange", "Course", AdditionalFields = "Degree", ErrorMessage = "Min Degree Is Invalid")]//url Ajax call "Contoller/action"
        [Required(ErrorMessage = "Min Degree Is Required")]
        public int MinDegree { get; set; }
        [Required(ErrorMessage ="Hours Is Required")]
        [DividedByThree]
        public int Hours { get; set; }

        public virtual List<Instructor>? Instructors { get; set; }

        [ForeignKey("Department")] 
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
