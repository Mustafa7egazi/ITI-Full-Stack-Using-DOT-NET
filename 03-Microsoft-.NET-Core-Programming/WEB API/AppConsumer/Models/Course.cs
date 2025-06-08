using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsumer.Models
{
    internal class Course
    {
       
        public int Id { get; set; }
       
        public string? Crs_name { get; set; }
       
        public string? Crs_desc { get; set; }
        public int? Crs_duration { get; set; }
    }
}
