using ITIWebAPIProjectDay02.Data;
using ITIWebAPIProjectDay02.Models;

namespace ITIWebAPIProject.Repository
{
    public class StudentRepository:GenericRepository<Student>
    {
        public StudentRepository(ITIContext _db):base(_db)
        {
            
        }

        public List<Student> GetCustomStudents(int pageNumber , int pageSize)
        {
            var totalCount = db.Students.Count();

            return db.Students
                             .Skip((pageNumber - 1) * pageSize)
                             .Take(pageSize)
                             .ToList();
        }

        public Student? GetByName(string name)
        {
            return db.Students.FirstOrDefault(s => s.StFname.ToLower() == name.ToLower() 
                                                || s.StLname.ToLower() == name.ToLower());
        }
    }
}
