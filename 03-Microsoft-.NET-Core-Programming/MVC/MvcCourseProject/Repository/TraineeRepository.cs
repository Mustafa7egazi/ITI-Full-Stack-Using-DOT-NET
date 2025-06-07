using Microsoft.EntityFrameworkCore;
using MvcCourseProject.Models.DBModels;

namespace MvcCourseProject.Repository
{
    public class TraineeRepository : ITraineeRepository
    {
        LearnContext context;
        public TraineeRepository(LearnContext _context)
        {
            context = _context;   
        }
        public void Add(Trainee obj)
        {
            context.Trainees.Add(obj);
        }

        public void Delete(int id)
        {
            Trainee? trainee = GetById(id);
            if (trainee != null)
            {
                context.Trainees.Remove(trainee);
            }
            else
            {
                throw new Exception("Trainee not found");
            }
        }

        public List<Trainee> GetAll()
        {
            return context.Trainees
                .Include(t => t.Department)
                .ToList();
        }

        public Trainee? GetById(int id)
        {
            return context.Trainees
                .Include(t => t.Department)
                .FirstOrDefault(t => t.Id == id);
        }

        public List<Trainee> GetMultipleTrainees(List<int> ids)
        {
            return context.Trainees
                .Where(t => ids.Contains(t.Id))
                .ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Trainee obj)
        {
            Trainee? oriinalTrainee = GetById(obj.Id);
            if (oriinalTrainee != null)
            {
                oriinalTrainee.Name = obj.Name;
                oriinalTrainee.Img = obj.Img;
                oriinalTrainee.Address = obj.Address;
                oriinalTrainee.Grade = obj.Grade;
                oriinalTrainee.DepartmentId = obj.DepartmentId;
            }
            else
            {
                throw new Exception("Trainee not found");
            }
        }
    }
}
