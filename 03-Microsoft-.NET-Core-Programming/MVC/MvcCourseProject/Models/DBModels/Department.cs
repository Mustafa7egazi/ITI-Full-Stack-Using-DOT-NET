using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCourseProject.Models.DBModels
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Instructor> Instructors { get; set; }

        [ForeignKey("Manager")]
        public int? ManagerId { get; set; }
        public Instructor Manager { get; set; }
    }
}
