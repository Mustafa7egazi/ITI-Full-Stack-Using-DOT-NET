using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01___LinqLab
{
    internal class Track
    {
        public int TrackId { get; set; }
        public string TrackName { get; set; }

        override public string ToString()
        {
            return $"{TrackId} - {TrackName}";
        }
    }

   
    }
