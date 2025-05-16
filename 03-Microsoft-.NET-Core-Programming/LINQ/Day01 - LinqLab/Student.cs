using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01___LinqLab
{
    internal class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal salary { get; set; }

        public int TrackId { get; set; }


        public override string ToString()
        {
            return $"{Id} - {FirstName} {LastName} - {Age} - {salary} - {TrackId}";
        }
    }
}
