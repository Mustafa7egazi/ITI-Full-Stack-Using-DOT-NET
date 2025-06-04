using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03__CrudWithDapper.Models
{
    internal class Course
    {
        public int Crs_Id { get; set; }
        public string Crs_Name { get; set; }
        public int Crs_Duration { get; set; }
        public int Top_Id { get; set; }
    }
}
