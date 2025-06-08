using System.ComponentModel.DataAnnotations;

namespace ITIWebAPIProjectDay02.DTOs.DepartmentDTO
{
    public class AddDepartmentDTO
    {
        [Required]
        public int DeptId { get; set; }
        [Required]

        public string? DeptName { get; set; }
        [Required]

        public string? DeptDesc { get; set; }
        [Required]

        public string? DeptLocation { get; set; }
    }
}
