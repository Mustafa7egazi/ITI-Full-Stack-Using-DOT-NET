using System.Collections;
using System.Runtime.Intrinsics.X86;

namespace Day02___LinqLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================================");
            Console.WriteLine("==================== Day02 - LINQ =======================");
            Console.WriteLine("=========================================================");

            #region Getting Data From Repo

            List<Employee> employees = Repository.GetEmployees();
            List<Department> departments = Repository.GetDepartments();

            #endregion

            #region Part01

            #region 1.First 4 Employees in the List Using Method Syntax [fluent syntax].
            var q1 = employees.Take(4);
            #endregion

            #region 2.First 3 Employees in the List with Salary more than 5000 Using Method Syntax [fluent syntax].

            var q2 = employees.Where(e => e.Salary > 5000).Take(3);

            #endregion

            #region 3.Last 4 Employees in the List Using Method Syntax [fluent syntax].
              
            var q3 = employees.Skip(employees.Count - 4);

            #endregion

            #region 4.Second 2 Employees in the List Using Method Syntax [fluent syntax].
            
            var q4 = employees.Skip(2).Take(2);

            #endregion

            #region 5.All Employees While Name length < 5 Using Method Syntax [fluent syntax].
            
            var q5 = employees.TakeWhile(e => e.Name.Length < 5);

            #endregion

            #region 6.Distinct Employees. Hint: (Using IEqualityComparer) Using Method Syntax [fluent syntax].

            List<Employee> emps = new List<Employee>
            {
                new Employee { Id = 1, Name = "Ahmed", Age = 26 , Salary = 1234, DeptId = 1},
                new Employee { Id = 2, Name = "Mohamed", Age = 36 , Salary = 2234, DeptId = 2},
                new Employee { Id = 2, Name = "Sara", Age = 46 , Salary = 4234, DeptId = 3},
                new Employee { Id = 5, Name = "Omar", Age = 25 , Salary = 5234, DeptId = 4},
                new Employee { Id = 5, Name = "Ali", Age = 25 , Salary = 6234, DeptId = 1}, 
            };
            var q6 = emps.Distinct(new EmpComp());

            #endregion

            #region 7.Name and Id of All Employees Using Method Syntax [fluent syntax].

            var q7 = employees.Select(e => new { e.Name, e.Id });

            #endregion

            #region 8.Name and Id of All Employees Using Query Syntax.

            var q8 = from emp in employees
                     select new { emp.Name, emp.Id };

            #endregion

            #region 9.Name and DeptName of All Employees Using Query Syntax.

            var q9 = from emp in employees
                     join dept in departments
                     on emp.DeptId equals dept.DeptId
                     select new { emp.Name, dept.DeptName };

            #endregion

            #region 10.Name and DeptName of All Employees Using Method Syntax [fluent syntax].

            var q10 = employees.Join(
                departments,
                emp => emp.DeptId,
                dept => dept.DeptId,
                (emp,dept)=> new { emp.Name, dept.DeptName }
                );

            #endregion

            #region 11.All Employees Group by DeptName Using Method Syntax [fluent syntax].

            var q11 = employees.Join(
                departments,
                emp => emp.DeptId,
                dept => dept.DeptId,
                (emp , dept)=> new { emp.Name , dept.DeptName }
                ).GroupBy(g => g.DeptName);


            //foreach (var group in q11)
            //{
            //    Console.WriteLine($"Group: {group.Key}");
            //    foreach (var emp in group)
            //    {
            //        Console.WriteLine($"\t{emp.Name}");
            //    }
            //}

            #endregion

            #region 12.All Employees Group by DeptName Using Query Syntax.

            var q12 = from emp in employees
                      join dept in departments
                      on emp.DeptId equals dept.DeptId
                      group emp by dept.DeptName;

            //foreach (var group in q12)
            //{
            //    Console.WriteLine($"Group: {group.Key}");
            //    foreach (var emp in group)
            //    {
            //        Console.WriteLine($"\t{emp.Name}");
            //    }
            //}



            #endregion

            #region 13.Min Salary, Max Salary, Avg Salary.

            var q13_1 = employees.Min(e => e.Salary);
            var q13_2 = employees.Max(e => e.Salary);
            var q13_3 = employees.Average(e => e.Salary);

            #endregion

            #region 14.Employee Where Salary < Avg Salary.

            var q14 = employees.Where(e => e.Salary < employees.Average(e => e.Salary));

            #endregion

            #region 15.Create two lists of int and try Expect, Concat, Union, Intersect.

            List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> list2 = new List<int> { 4, 5, 6, 7, 8 };
            var q15_1 = list1.Concat(list2);
            var q15_2 = list1.Union(list2);
            var q15_3 = list1.Intersect(list2);
            var q15_4 = list1.Except(list2);

            #endregion

            #region 16.Create list of Phone Number and Names and try Zip Operator.

            List<string> phoneNumbers = new List<string> { "1234567890", "0987654321", "1122334455" };
            List<string> names = new List<string> { "Omar", "Ali", "Mona" };

            var q16 = phoneNumbers.Zip(names);
            var q16_2 = phoneNumbers.Zip(names,(n,p)=> new {Name = n , Phone = p});

            //foreach (var item in q16_2)
            //{
            //    Console.WriteLine($"Phone Number: {item.Phone}, Name: {item.Name}");
            //}

            #endregion

            #endregion

            #region Part02

            #region Task01

            #region Query1: Display numbers without any repeated Data and sorted 

            List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };
            var query1 = numbers.Distinct().OrderBy(n => n);

            #endregion

            #region Query2: using Query1  result and show each number and it’s multiplication 

            var query2 = from num in query1
                         select new
                         {
                             Number = num,
                             Multiplication = num * num
                         };


            #endregion

            #endregion

            #region Task02

            #region Query1: Select names with length equal 3. 

            string[] namess = { "Tom", "Dick", "Harry", "MARY", "Jay" };

            var query3 = from name in namess
                         where name.Length == 3
                         select name;

            var query3_2 = namess.Where(name => name.Length == 3);

            #endregion

            #region Query2: Select names that contains “a” letter (Capital or Small )then sort them by length

            var query4 = from name in namess
                         where name.ToLower().Contains("a")
                         orderby name.Length
                         select name;

            var query4_2 = namess.Where(name => name.ToLower().Contains("a"))
                .OrderBy(name => name.Length);

            #endregion

            #region Query3: Display the first 2 names 

            var query5 = namess.Take(2);

            var query5_2 = (from name in namess
                            select name).Take(2);

            #endregion


            #endregion

            #region Task03

            List<Student> students = new List<Student>(){
            new Student(){ ID=1, FirstName="Ali", LastName="Mohammed",
            subjects=new Subject[]{ new Subject(){ Code=22,Name="EF"},
                new Subject(){Code=33,Name="UML"}}},

            new Student(){ ID=2, FirstName="Mona", LastName="Gala",
                subjects=new Subject []{ new Subject(){ Code=22,Name="EF"},
                    new Subject (){Code=34,Name="XML"},
                    new Subject (){ Code=25, Name="JS"}}},   
            
                new Student(){ ID=3, FirstName="Yara", LastName="Yousf", 
                    subjects=new Subject[]{ new Subject (){ Code=22,Name="EF"}, 
                        new Subject (){ Code=25,Name="JS"}}},

             new Student(){ ID=1, FirstName="Ali", LastName="Ali",
                subjects=new Subject []{  new Subject (){ Code=33,Name="UML"}}},
            };

            #region Query1: Display Full name and number of subjects for each student as follow 

            var query6 = students.Select(s => new
            {
                FullName = s.FirstName + " " + s.LastName,
                NumberOfSubjects = s.subjects.Length
            });

            //foreach (var item in query6)
            //{
            //    Console.WriteLine($"Full Name: {item.FullName}, Number of Subjects: {item.NumberOfSubjects}");
            //}

            #endregion

            #region Query2: Write a query which orders the elements in the list by FirstName Descending then by LastName Ascending

            var query7 = students
                .OrderByDescending(s => s.FirstName)
                .ThenBy(s => s.LastName)
                .Select( s => s.FirstName + " " + s.LastName );


            #endregion

            #region Query3:Display each student and student’s subject as follow (use selectMany) 

            var query8 = students.SelectMany(
                        student => student.subjects,
                        (student, subject) => new
                        {
                            StudentName = student.FirstName + " " + student.LastName,
                            SubjectName = subject.Name
                        });

            //foreach (var item in query8)
            //{
            //    Console.WriteLine($"<Student Name: {item.StudentName}, Subject Name: {item.SubjectName}>");
            //}

            #endregion

            #region Then as follow (use GroupBy) 

            var query9 = students
                 .GroupBy(s => s.FirstName + " " + s.LastName) 
                 .Select(g => new
                 {
                    FullName = g.Key,
                    Subjects = g.SelectMany(s => s.subjects)    
                               .Select(sub => sub.Name)         
                                       
                 });

            //foreach (var group in query9)
            //{
            //    Console.WriteLine($"{group.FullName}");  
            //    foreach (var subject in group.Subjects)
            //    {
            //        Console.WriteLine($"\t-{subject}");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #endregion

            #endregion

            #region Part03

            List<Book> books = SampleData.GetBooks();
            List<Publisher> publishers = SampleData.Publishers.ToList();


            #region 1- Display book title and its ISBN.

            var q1_1 = from book in books
                       select new { book.Title, book.Isbn };

            //foreach (var item in q1_1)
            //{
            //    Console.WriteLine($"Title: {item.Title}, ISBN: {item.Isbn}");
            //}

            #endregion

            #region 2-Display the first 3 books with price more than 25.

            var q2_1 = books.Where(b => b.Price > 25).Take(3);

            #endregion

            #region 3-Display Book title along with its publisher name.

            var q3_1 = from book in books
                       join publisher in publishers
                       on book.Publisher.Name equals publisher.Name
                       select new { book.Title, publisher.Name };

            #endregion

            #region 4-Find the number of books which cost more than 20.

            var q4_1 = books.Count(b => b.Price > 20);

            #endregion

            #region 5-Display book title, price and subject name sorted by its subject name ascending and by its price descending

            var q5_1 = from book in books
                       orderby book.Subject.Name ascending, book.Price descending
                       select new { book.Title, book.Price, book.Subject.Name };

            //foreach (var item in q5_1)
            //{
            //    Console.WriteLine($"Title: {item.Title}, Price: {item.Price}, Subject: {item.Name}");
            //}

            #endregion

            #region 6-Display all subjects with books related to this subject. (Using 2 methods).

            var q6_1 = books.GroupBy(b => b.Subject.Name)
                            .Select(g => new
                            {
                                SubjectName = g.Key,
                                Books = g.Select(b => b.Title)
                            });

            var q6_2 = from book in books
                       group book by book.Subject.Name into groups
                       select new
                       {
                           SubjectName = groups.Key,
                           Books = groups.Select(b => b.Title)
                       };

            var q6_3 = SampleData.Subjects.Select(s=> new {s.Name  , books = books.Where(b => b.Subject.Name == s.Name)});

            //foreach (var group in q6_1)
            //{
            //    Console.WriteLine($"Subject: {group.SubjectName}");
            //    foreach (var book in group.Books)
            //    {
            //        Console.WriteLine($"\t- {book}");
            //    }
            //}

            #endregion

            #region 7-Display books grouped by publisher & Subject.

            var q7_1 = books.GroupBy(b => new { b.Publisher.Name, b.Subject })
                            .Select(g => new
                            {
                                PublisherName = g.Key.Name,
                                SubjectName = g.Key.Name,
                                Books = g.Select(b => b.Title)
                            });

            foreach (var group in q7_1)
            {
                Console.WriteLine($"Publisher: {group.PublisherName}, Subject: {group.SubjectName}");
                foreach (var book in group.Books)
                {
                    Console.WriteLine($"\t- {book}");
                }
            }

            #endregion

            #endregion

        }
    }
}
