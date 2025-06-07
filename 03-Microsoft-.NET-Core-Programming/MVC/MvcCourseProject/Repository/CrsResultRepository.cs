using Microsoft.EntityFrameworkCore;
using MvcCourseProject.Models.DBModels;

namespace MvcCourseProject.Repository
{
    public class CrsResultRepository : ICrsResultRepository
    {
        private  LearnContext context;

        public CrsResultRepository(LearnContext _context)
        {
            context = _context;
        }
        public void Add(CrsResult obj)
        {
            context.CrsResults.Add(obj);
        }

        public List<int> AllTraineesIdsInCourse(int cid)
        {
            return context.CrsResults
                .Where(crs => crs.Crs_Id == cid)
                .Select(crs => crs.Trainee_Id)
                .ToList();
        }

        public void Delete(int id)
        {
            CrsResult? result = GetById(id);
            if (result != null)
            {
                context.CrsResults.Remove(result);
            }
            else
            {
                throw new ArgumentException("CrsResult with the specified ID does not exist.");
            }
        }

        public List<CrsResult> GetAll()
        {
            return context.CrsResults
                .Include(cr => cr.Trainee)
                .Include(cr => cr.Course)
                .ToList();
        }

        public CrsResult? GetById(int id)
        {
            return context.CrsResults
                .Include(cr => cr.Trainee)
                .Include(cr => cr.Course)
                .FirstOrDefault(cr => cr.Id == id);
        }

        public CrsResult? GetCrsResultByCourseIdAndTraineeId(int tid, int cid)
        {
            return context.CrsResults
                .Where(crs => crs.Trainee_Id == tid && crs.Crs_Id == cid)
                .FirstOrDefault();
        }

        public List<CrsResult> GetCrsResultsByTraineeId(int traineeId)
        {
            return context.CrsResults
                .Where(crs => crs.Trainee_Id == traineeId)
                .ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(CrsResult obj)
        {
            CrsResult? existingResult = GetById(obj.Id);
            if (existingResult != null)
            {
                existingResult.Degree = obj.Degree;
                existingResult.Crs_Id = obj.Crs_Id;
                existingResult.Trainee_Id = obj.Trainee_Id;
                context.CrsResults.Update(existingResult);
            }
            else
            {
                throw new ArgumentException("CrsResult with the specified ID does not exist.");
            }
        }
    }
}
