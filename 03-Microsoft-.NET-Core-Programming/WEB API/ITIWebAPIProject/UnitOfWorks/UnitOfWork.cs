using ITIWebAPIProject.Repository;
using ITIWebAPIProjectDay02.Data;

namespace ITIWebAPIProject.UnitOfWorks
{
    public class UnitOfWork
    {
        private ITIContext db;
        private StudentRepository studentRepository;
        public StudentRepository StudentRepository
        {
            get
            {
                if (studentRepository == null)
                {
                    studentRepository = new StudentRepository(db);
                }
                return studentRepository;
            }
        }
        private DepartmentRepository departmentRepository;
        public DepartmentRepository DepartmentRepository
        {
            get
            {
                if (departmentRepository == null)
                {
                    departmentRepository = new DepartmentRepository(db);
                }
                return departmentRepository;
            }

        }

        public UnitOfWork(ITIContext _db)
        {
            db = _db;
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
