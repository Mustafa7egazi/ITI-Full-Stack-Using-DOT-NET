using MvcCourseProject.Models.DBModels;

namespace MvcCourseProject.Repository
{
    public interface ICourseRepository:IRepoository<Course>
    {
        // here add custom methods specific to Course repository if needed

        public Course? GetCourseByNameAndDeptId(string crsName, int deptId);
    }
}
