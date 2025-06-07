using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCourseProject.Models.DBModels
{
    public class CrsResult
    {
        [Key]
        public int Id { get; set; }
        public int Degree { get; set; }
        [ForeignKey("Course")]
        public int Crs_Id { get; set; }
        public Course Course { get; set; }
        [ForeignKey("Trainee")]
        public int Trainee_Id { get; set; }
        public Trainee Trainee { get; set; }
    }
}
