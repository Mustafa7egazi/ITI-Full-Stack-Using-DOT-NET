using Microsoft.EntityFrameworkCore;
using MvcCourseProject.Models.DBModels;

namespace MvcCourseProject.Repository
{
    public class InstructorRepository : IInstructorRepository
    {
        private LearnContext context;

        public InstructorRepository(LearnContext _context)
        {
            context = _context;
            //context = new LearnContext(); before injection
        }
        public void Add(Instructor obj)
        {
            context.Instructors.Add(obj);
        }

        public void Delete(int id)
        {
           Instructor? instructorToDelete = GetById(id);
            if (instructorToDelete != null)
            {
                context.Instructors.Remove(instructorToDelete);
            }
            else
            {
                throw new ArgumentException("Instructor not found with the given id.");
            }
        }

        public List<Instructor> GetAll()
        {
            return context.Instructors
                .Include(i => i.Department)
                .Include(i => i.Course)
                .ToList();
        }

        public Instructor? GetById(int id)
        {
            return context.Instructors
                 .Include(i => i.Department)
                 .Include(i => i.Course)
                 .FirstOrDefault(i => i.Id == id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Instructor obj)
        {
            Instructor? originalInstructor = GetById(obj.Id);
            if (originalInstructor != null)
            {
                originalInstructor.Name = obj.Name;
                originalInstructor.Address = obj.Address;
                originalInstructor.Img = obj.Img;
                originalInstructor.Salary = obj.Salary;
                originalInstructor.DepartmentId = obj.DepartmentId;
                originalInstructor.Crs_id = obj.Crs_id;
                context.Instructors.Update(originalInstructor);
            }
            else
            {
                throw new ArgumentException("Instructor not found with the given id.");
            }
        }
    }
}
