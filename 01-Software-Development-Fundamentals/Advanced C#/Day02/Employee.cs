class Employee :IComparable<Employee>
{
    public int ID { get; set; }
    public string Level { get; set; }
    public double Salary { get; set; }
    public HiringDate HireDate { get; set; }


    public Employee(int id, string level, double salary, HiringDate hireDate)
    {
        ID = id;
        Level = level;
        Salary = salary;
        HireDate = hireDate;
    }

    public override string ToString()
    {
        return $"ID: {ID}, Level: {Level}, Salary: {Salary}, Hire Date: {HireDate}";
    }

    public int CompareTo(Employee? other)
    {
        return HireDate.CompareTo(other.HireDate);
    }
}
