namespace ITIWebAPIProjectDay02.DTOs.StudentDTO
{
    public class DisplayStudentDTO
    {
        public int StId { get; set; }

        public string? StFname { get; set; }

        public string? StLname { get; set; }

        public string? StAddress { get; set; }

        public int? StAge { get; set; }

        public int? DeptId { get; set; }
        public string? DeptName { get; set; }
        public string? SupervisorName { get; set; }

    }
}
