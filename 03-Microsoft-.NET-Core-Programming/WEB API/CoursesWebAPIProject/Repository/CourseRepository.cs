using WebAPIProject.Models;

namespace WebAPIProject.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly SDDBContext _context;
        public CourseRepository(SDDBContext context)
        {
            _context = context;
        }
        public Course? CourseByName(string name)
        {
            return _context.Courses.FirstOrDefault(c => c.Crs_name == name);
        }

        public void DeleteCourse(int id)
        {
            Course? course = GetById(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
            }
            else
            {
                throw new ArgumentException($"Course with ID {id} not found.", nameof(id));
            }
        }

        public List<Course> Get()
        {
            return _context.Courses.ToList();
        }

        public Course? GetById(int id)
        {
            return _context.Courses.FirstOrDefault(c => c.Id == id);
        }

        public void Post(Course entity)
        {
            _context.Courses.Add(entity);
        }

        public void Put(int id, Course entity)
        {
            Course? c = GetById(id);
            if (c != null)
            {
                c.Crs_name = entity.Crs_name;
                c.Crs_desc = entity.Crs_desc;
                c.Crs_duration = entity.Crs_duration;
                _context.Courses.Update(c);
            }
            else
            {
                throw new ArgumentException($"Course with ID {id} not found.", nameof(id));
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
