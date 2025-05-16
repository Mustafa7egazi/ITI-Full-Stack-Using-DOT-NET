using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01___LinqLab
{
    internal class Repository
    {
        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
               new Student { Id = 1, FirstName = "Ahmed", LastName = "Mohamed", Age = 26, salary = 1234m, TrackId = 1 },
            new Student { Id = 2, FirstName = "Fatima", LastName = "Ali", Age = 24, salary = 6325m, TrackId = 2 },
            new Student { Id = 3, FirstName = "Omar", LastName = "Khalid", Age = 25, salary = 4669m, TrackId = 1 },
            new Student { Id = 4, FirstName = "Aisha", LastName = "Hassan", Age = 25, salary = 5555m, TrackId = 3 },
            new Student { Id = 5, FirstName = "Youssef", LastName = "Ibrahim", Age = 27, salary = 1400m, TrackId = 4 },
            new Student { Id = 6, FirstName = "Layla", LastName = "Mahmoud", Age = 22, salary = 1250m, TrackId = 2 },
            new Student { Id = 7, FirstName = "Khalid", LastName = "Abdullah", Age = 28, salary = 1700m, TrackId = 3 },
            new Student { Id = 8, FirstName = "Noor", LastName = "Omar", Age = 21, salary = 1200m, TrackId = 1 },
            new Student { Id = 9, FirstName = "Mariam", LastName = "Yasin", Age = 31, salary = 1550m, TrackId = 4 },
            new Student { Id = 10, FirstName = "Ziad", LastName = "Farid", Age = 33, salary = 1450m, TrackId = 2 }

            };
        }

        public static List<Track> GetTracks()
        {
            return new List<Track>()
            {
                new Track { TrackId = 1, TrackName = "C#" },
                new Track { TrackId = 2, TrackName = "Java" },
                new Track { TrackId = 3, TrackName = "Python" },
                new Track { TrackId = 4, TrackName = "JavaScript" }
            };
        }
    }
}
