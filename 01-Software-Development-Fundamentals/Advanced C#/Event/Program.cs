namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmp = new List<Employee>();
            listEmp.AddRange(new List<Employee>
           {
               new Employee(1, new DateTime(2000, 5, 16), 5),
               new Employee(2, new DateTime(1995, 4, 16), -2),
               new Employee(3, new DateTime(1960, 5, 16), 0)
           });

            Department hr = new Department() { DeptID = 1, DeptName = "HR" };
            Department sd = new Department() { DeptID = 2, DeptName = "SD" };

            Club cityClub = new Club() { ClubID = 1, ClubName = "City Club" };
            Club ahlyClub = new Club() { ClubID = 2, ClubName = "Ahly Club" };

            foreach (Employee emp in listEmp)
            {
                hr.AddStaff(emp);
                sd.AddStaff(emp);

                cityClub.AddMember(emp);
                ahlyClub.AddMember(emp);
                emp.EndOfYearOperation();
            }
        }
    }
}
