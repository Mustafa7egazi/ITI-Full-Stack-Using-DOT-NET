namespace Event
{

    class Club
    {
        public int ClubID { get; set; }
        public string ClubName { get; set; }
        private List<Employee> Members = new List<Employee>();

        public void AddMember(Employee E)
        {
            Members.Add(E);
            E.EmployeeLayOff += RemoveMember;
        }

   
        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            Employee emp = sender as Employee;
            if (emp != null)
            {
                if (e.Cause == LayOffCause.VacationStock)
                {
                    Members.Remove(emp);
                    Console.WriteLine($"Employee {emp.EmployeeID} removed from club due to {e.Cause}");

                }
                else if (e.Cause == LayOffCause.Age)
                {
                    Console.WriteLine($"Employee {emp.EmployeeID} still in club");
                }
            }
        }
    }
}
