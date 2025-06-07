using MvcCourseProject.Models.DBModels;

namespace MvcCourseProject.Repository
{
    public interface ITraineeRepository:IRepoository<Trainee>
    {
        public List<Trainee> GetMultipleTrainees(List<int> ids);
    }
}
