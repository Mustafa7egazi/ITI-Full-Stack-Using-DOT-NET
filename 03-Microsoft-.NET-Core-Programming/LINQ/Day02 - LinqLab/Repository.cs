namespace Day02___LinqLab
{
    public class Repository
    {
        /*-------------------------------------------------------------------------*/
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee { Id = 1, Name = "Ahmed", Age = 26 , Salary = 1234, DeptId = 1},
                new Employee { Id = 2, Name = "Mohamed", Age = 36 , Salary = 2234, DeptId = 2},
                new Employee { Id = 3, Name = "Sara", Age = 46 , Salary = 4234, DeptId = 3},
                new Employee { Id = 4, Name = "Omar", Age = 25 , Salary = 5234, DeptId = 4},
                new Employee { Id = 5, Name = "Ali", Age = 25 , Salary = 6234, DeptId = 1},
                new Employee { Id = 6, Name = "Mai", Age = 36 , Salary = 7234, DeptId = 2},
                new Employee { Id = 7, Name = "Ramy", Age = 49 , Salary = 8234, DeptId = 3},
                new Employee { Id = 8, Name = "Hamada", Age = 18 , Salary = 9234, DeptId = 4},
                new Employee { Id = 9, Name = "Hatem", Age = 26 , Salary = 10234, DeptId = 1},
                new Employee { Id = 10, Name = "Osama", Age = 25 , Salary = 17234, DeptId = 2},
            };
        }
        /*-------------------------------------------------------------------------*/
        public static List<Department> GetDepartments()
        {
            return new List<Department>()
            {
                new Department {  DeptId = 1 , DeptName = "SD" },
                new Department {  DeptId = 2 , DeptName = "UI" },
                new Department {  DeptId = 3 , DeptName = "Mob" },
                new Department {  DeptId = 4 , DeptName = "Network" },
            };
        }
        /*-------------------------------------------------------------------------*/
    }
}
