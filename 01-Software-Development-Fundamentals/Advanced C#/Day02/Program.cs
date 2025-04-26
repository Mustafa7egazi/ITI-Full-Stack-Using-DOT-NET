using System;

class Program
{
    static void Main()
    {
        Employee[] EmpArr = new Employee[3];

        EmpArr[0] = new Employee(
            id: 1,
            level: "DBA",
            salary: 1000,
            hireDate: new HiringDate(day: 1, month: 5, year: 2000)
        );

        EmpArr[1] = new Employee(
            id: 2,
            level: "Guest",
            salary: 2000,
            hireDate: new HiringDate(day: 6, month: 5, year: 2000)
        );


        int day, month, year;


        Console.WriteLine("Enter Day");
        int.TryParse(Console.ReadLine(),out day);
        Console.WriteLine("Enter Month");
        int.TryParse(Console.ReadLine(),out month);
        Console.WriteLine("Enter Year");
        int.TryParse(Console.ReadLine(),out year);


        EmpArr[2] = new Employee(
            id: 3,
            level: "Officer",
            salary: 3000,
            hireDate:new HiringDate(day,month,year)
        );


        Array.Sort( EmpArr );

        Console.WriteLine("\nEmployees after sorting");
        foreach (var emp in EmpArr)
        {
            Console.WriteLine(emp);
        }
    }

}
