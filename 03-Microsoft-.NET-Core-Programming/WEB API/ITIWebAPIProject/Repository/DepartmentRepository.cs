using ITIWebAPIProjectDay02.Data;
using ITIWebAPIProjectDay02.Models;

namespace ITIWebAPIProject.Repository
{
    public class DepartmentRepository:GenericRepository<Department>
    {
        public DepartmentRepository(ITIContext _db):base(_db)
        {
            
        }

        public List<Department> GetByName(string name)
        {
            return db.Departments.Select(d => d).Where(d => d.DeptName.ToLower().Contains(name.ToLower())).ToList();
        }

        public List<Department> GetCustomDepartments(int pageNumber , int pageSize)
        {
            var totalCount = db.Departments.Count();

           return db.Departments
                                .Skip((pageNumber - 1) * pageSize)
                                .Take(pageSize)
                                .ToList();
        }

    }
}
