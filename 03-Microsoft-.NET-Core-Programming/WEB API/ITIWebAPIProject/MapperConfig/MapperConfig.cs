using AutoMapper;
using ITIWebAPIProjectDay02.Data;
using ITIWebAPIProjectDay02.DTOs.DepartmentDTO;
using ITIWebAPIProjectDay02.DTOs.StudentDTO;
using ITIWebAPIProjectDay02.Models;

namespace ITIWebAPIProjectDay02.MapperConfig
{
    public class AutoMapperConfig : Profile
    {
       
        public AutoMapperConfig()
        {
           
            CreateMap<Student, DisplayStudentDTO>().AfterMap((s, d) =>
            {
                d.DeptName = s.Dept?.DeptName;
                d.SupervisorName = $"{s.StSuperNavigation?.StFname ?? ""} {s.StSuperNavigation?.StLname ?? ""}".Trim();
                
            }).ReverseMap();
            CreateMap<Student, AddStudentDTO>().ReverseMap();
            CreateMap<Department, AddDepartmentDTO>().ReverseMap();
            CreateMap<Department, DisplayDepartmentDTO>().AfterMap((s, d) =>
            {

                d.DeptManager = s?.DeptManagerNavigation?.InsName?? "No Assigned Manager";
                d.NumberOfStudents = s?.Students.Count();

            }).ReverseMap();

        }
    }
}
