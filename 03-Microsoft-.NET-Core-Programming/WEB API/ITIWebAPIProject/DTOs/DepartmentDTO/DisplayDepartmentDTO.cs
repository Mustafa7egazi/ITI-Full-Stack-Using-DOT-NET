using System.Text.Json.Serialization;

namespace ITIWebAPIProjectDay02.DTOs.DepartmentDTO
{
    public class DisplayDepartmentDTO
    {
        public int DeptId { get; set; }

        public string? DeptName { get; set; }

        public string? DeptDesc { get; set; }

        public string? DeptLocation { get; set; }

        public string? DeptManager { get; set; }

        public int? NumberOfStudents { get; set; }

    }
}
