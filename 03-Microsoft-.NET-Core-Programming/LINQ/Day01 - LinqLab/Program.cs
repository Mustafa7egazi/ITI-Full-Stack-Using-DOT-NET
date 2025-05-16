namespace Day01___LinqLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================================================");
            Console.WriteLine("=============================== LINQ - Day01 ==============================");
            Console.WriteLine("===========================================================================");


            #region Getting data from repo

            var allStudents = Repository.GetStudents();
            var allTracks = Repository.GetTracks();

            #endregion

            #region 1.Display all Student using LINQ Query Expression.
            //var q1 = from s in allStudents
            //         select s;

            //foreach (var s in q1)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion

            Console.WriteLine("=================================================");
            #region 2.Display all Student using LINQ Method Syntax [fluent syntax].

            //var q2 = allStudents.OrderBy(s => s.Id);
            //foreach (var s in q2)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion


            Console.WriteLine("=================================================");
            #region 3.Display all Students with Age > 30 using LINQ Query Expression.

            //var q3 = from s in allStudents
            //         where s.Age > 30
            //         select s;

            //foreach (var s in q3)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion


            Console.WriteLine("=================================================");
            #region 4.Display all Students with Salary < 5000 using LINQ Method Syntax [fluent syntax].

            //var q4 = allStudents.Where(s => s.salary > 5000);
            //foreach (var s in q4)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion


            Console.WriteLine("=================================================");
            #region 5.Display all Students with TrackId =1 and salary > 4000 OrderBy Name descending using LINQ Query Expression

            //var q5 = from s in allStudents
            //         where s.TrackId == 1 && s.salary > 4000
            //         orderby s.FirstName descending
            //         select s;
            //foreach (var s in q5)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion

            Console.WriteLine("=================================================");
            #region 6.	Display all Students with TrackId = 1 and first name Contains ‘m’ OrderBy Salary 

            //var q6 = allStudents
            //    .Where(s => s.TrackId == 1 && s.FirstName.ToLower().Contains('m'))
            //    .OrderBy(s => s.salary);

            //foreach (var s in q6)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion

            Console.WriteLine("=================================================");
            #region 7.Find First Student with Salary more than 5000. 

            //var q7 = allStudents.First(s => s.salary > 5000);
            //    Console.WriteLine(q7);

            //var q71 = allStudents.FirstOrDefault(s => s.salary > 8000);
            //Console.WriteLine(q71 == null ? "No matching": q71);
            #endregion


            Console.WriteLine("=================================================");
            #region 8.Find Last Student in Track number 10. 

            //var q8 = allStudents.Last(s => s.TrackId == 10);
            //Console.WriteLine(q8); // will throw exception because there is no student with TrackId = 10

            //var q81 = allStudents.LastOrDefault(s => s.TrackId == 10);
            //Console.WriteLine(q81 == null? "No matching" : q81);
            #endregion

            Console.WriteLine("=================================================");
            #region 9.Find Student with Age equal 25.

            //var q9 = allStudents.Single(s => s.Age == 25); // will throw error if no match or there are more than one value returned 
            //Console.WriteLine(q9);

            //var q91 = allStudents.SingleOrDefault(s => s.Age == 25); // will throw error if there are more than one value returned if not match return null
            //Console.WriteLine(q91 == null ? "q9 No matching" : $"q9 - {q91}");
            #endregion


            Console.WriteLine("=================================================");
            #region 10.Find Student with TrackId equal 8.

            //var q10 = allStudents.Single(s => s.TrackId == 8); // will throw error if no match or there are more than one value returned 
            //Console.WriteLine(q9);

            //var q101 = allStudents.SingleOrDefault(s => s.TrackId == 8); // will throw error if there are more than one value returned if not match return null
            //Console.WriteLine(q101 == null ? "No matching" : $"{q101}");
            #endregion

            Console.WriteLine("=================================================");
            #region 11.Find Student in index 4.

            //var q11 = allStudents.ElementAt(4);
            //Console.WriteLine(q11);

            #endregion


            Console.WriteLine("=================================================");
            #region  User wanted sort
            Console.WriteLine("Enter a sorting way\n" +
                "1 by name\n2 by age");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                if (choice == 1)
                {

                    Console.WriteLine("Enter order way\n" +
                        "1 for ascending\n" +
                        "2 for descending");

                    if (int.TryParse(Console.ReadLine(), out int way))
                    {

                        if (way == 1)
                        {
                            var query1 = from s in allStudents
                                         orderby s.FirstName ascending
                                         select s;

                            foreach (var s in query1)
                            {
                                Console.WriteLine(s);
                            }
                        }
                        else if (way == 2)
                        {
                            var query2 = from s in allStudents
                                         orderby s.FirstName descending
                                         select s;

                            foreach (var s in query2)
                            {
                                Console.WriteLine(s);
                            }
                        }
                        else
                        {
                            Console.WriteLine("invalid choice");
                        }


                    }
                    else
                    {
                        Console.WriteLine("invalid choice");
                    }

                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter order way\n" +
                       "1 for ascending\n" +
                       "2 for descending");

                    if (int.TryParse(Console.ReadLine(), out int way))
                    {

                        if (way == 1)
                        {
                            var query1 = from s in allStudents
                                         orderby s.Age ascending
                                         select s;

                            foreach (var s in query1)
                            {
                                Console.WriteLine(s);
                            }
                        }
                        else if (way == 2)
                        {
                            var query2 = from s in allStudents
                                         orderby s.Age descending
                                         select s;

                            foreach (var s in query2)
                            {
                                Console.WriteLine(s);
                            }
                        }
                        else
                        {
                            Console.WriteLine("invalid choice");
                        }


                    }
                    else
                    {
                        Console.WriteLine("invalid choice");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }

            #endregion


        }
    }
}
