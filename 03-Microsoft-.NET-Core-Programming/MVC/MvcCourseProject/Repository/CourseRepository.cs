using Microsoft.EntityFrameworkCore;
using MvcCourseProject.Models.DBModels;

namespace MvcCourseProject.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private LearnContext context;

        public CourseRepository(LearnContext _context)
        {
            context = _context;
            //context = new LearnContext(); before injection
        }
        public void Add(Course obj)
        {
            context.Courses.Add(obj);
        }

        public void Delete(int id)
        {
            Course? courseToDelete = GetById(id);
            if (courseToDelete != null)
            {
                context.Courses.Remove(courseToDelete);
            }
            else
            {
                throw new Exception("Course not found");
            }
        }

        public List<Course> GetAll()
        {
            return context.Courses
                .Include(c => c.Department)
                 .Include(c => c.Instructors)
                .ToList();
        }

        public Course? GetById(int id)
        {
            return context.Courses
                .Include(c => c.Department)
                .Include(c => c.Instructors)
                .FirstOrDefault(c => c.Id == id);
        }

        public void Update(Course obj)
        {
            Course? originalCourse = GetById(obj.Id);
            if (originalCourse != null)
            {
                originalCourse.Name = obj.Name;
                originalCourse.Degree = obj.Degree;
                originalCourse.MinDegree = obj.MinDegree;
                originalCourse.Hours = obj.Hours;
                originalCourse.DepartmentId = obj.DepartmentId;
                
            }
            else
            {
                throw new Exception("Course not found");
            }
        }



        public void Save()
        {
            context.SaveChanges();
        }

        public Course? GetCourseByNameAndDeptId(string crsName, int deptId)
        {
            return context.Courses.FirstOrDefault(c => c.Name == crsName && c.DepartmentId == deptId);
        }
    }
}
