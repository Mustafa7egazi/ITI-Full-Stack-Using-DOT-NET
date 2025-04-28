namespace Event
{
    class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }

        List<Employee> Staff = new List<Employee>();


        public void AddStaff(Employee E)
        {
            Staff.Add(E);
            E.EmployeeLayOff += RemoveStaff;
        }


        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            Employee? emp = sender as Employee;
            if (emp != null)
            {
                Staff.Remove(emp);
                Console.WriteLine($"Employee {emp.EmployeeID} layed off from Department {DeptName} because of {e.Cause}");
            }
        }
    }
}
