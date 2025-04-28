namespace Event
{
    enum LayOffCause
    {
        VacationStock,
        Age
    }

    internal class EmployeeLayOffEventArgs : EventArgs
    {
        public LayOffCause Cause { get; set; }

    }

    class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
        public int EmployeeID { get; set; }

        private DateTime birthDate;
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        private int vacationStock;
        public int VacationStock
        {
            get { return vacationStock; }
            set { vacationStock = value; }
        }

        public Employee(int employeeID, DateTime birthDate, int vacationStock)
        {
            EmployeeID = employeeID;
            BirthDate = birthDate;
            VacationStock = vacationStock;
        }

        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }

        public bool RequestVacation(DateTime From, DateTime To)
        {
            int duration = (To - From).Days;
            if (duration <= vacationStock)
            {
                vacationStock -= duration;
                return true;
            }
            return false;
        }
        public void EndOfYearOperation()
        {
            if (vacationStock <= 0)
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.VacationStock });
            else if (DateTime.Now.Year - birthDate.Year > 60)
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.Age });
        }
    }
}
