using MvcCourseProject.Models.DBModels;

namespace MvcCourseProject.Repository
{
    public interface ICrsResultRepository:IRepoository<CrsResult>
    {
        // here we can add any specific methods related to CrsResult if needed

        public CrsResult? GetCrsResultByCourseIdAndTraineeId(int tid, int cid);
        public List<int> AllTraineesIdsInCourse(int cid);

        public List<CrsResult> GetCrsResultsByTraineeId(int traineeId);

    }
}
