using MvcCourseProject.Models.DBModels;

namespace MvcCourseProject.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private LearnContext context;

        public DepartmentRepository(LearnContext _context)
        {
            context = _context;
            //context = new LearnContext(); before injection
        }

        public void Add(Department obj)
        {
            context.Departments.Add(obj);
        }

        public void Delete(int id)
        {
            Department departmentToDelete = GetById(id);
            if (departmentToDelete != null)
            {
                context.Departments.Remove(departmentToDelete);
            }
            else
            {
                throw new Exception("Department not found");
            }
        }

        public List<Department> GetAll()
        {
            return context.Departments.ToList();
        }

        public Department? GetById(int id)
        {
            return context.Departments.FirstOrDefault(d => d.Id == id);
        }

        public void Update(Department obj)
        {
            Department? originalDepartment = GetById(obj.Id);
            if (originalDepartment != null)
            {
                originalDepartment.Name = obj.Name;
                originalDepartment.ManagerId = obj.ManagerId;
            }
            else
            {
                throw new Exception("Department not found");
            }
        }

        public void Save()
        {
           context.SaveChanges();
        }

     
    }
}
