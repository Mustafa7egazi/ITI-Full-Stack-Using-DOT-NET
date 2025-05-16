using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_ADO__simpleCRUD
{
    internal class Course
    {
        public int crs_id { get; set; }
        public string crs_name { get; set; }
        public int crs_duration { get; set; }
        public int? top_id { get; set; }
    }
}
