using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignmentDay06.Inheritance_Models
{
    internal class Circle:Shape
    {
        public Circle(double r):base(r) { }
        public double Area()
        {
            return Math.PI * dim1 * dim2;
        }
    }
}
