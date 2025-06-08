using System.ComponentModel.DataAnnotations;

namespace WebAPIProject.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string? Crs_name { get; set; }
        [StringLength(150)]
        public string? Crs_desc { get; set; }
        public int? Crs_duration { get; set; }

    }
}
