using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCourseProject.Models.DBModels
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        public string Img { get; set; }
        [Column(TypeName = "money")]
        public int Salary { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        [ForeignKey("Course")]
        public int Crs_id { get; set; }
        public Course Course { get; set; }

    }
}
