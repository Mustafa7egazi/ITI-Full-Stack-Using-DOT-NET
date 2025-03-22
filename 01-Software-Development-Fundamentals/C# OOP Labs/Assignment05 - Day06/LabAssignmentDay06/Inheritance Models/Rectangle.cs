using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignmentDay06.Inheritance_Models
{
    internal class Rectangle : Shape
    {
        public Rectangle()
        {
            dim1 = dim2 = 0;
        }

        public Rectangle(double dim1, double dim2) : base(dim1, dim2) { }

        /* In case it's a square */
        public Rectangle(double dim) : base(dim,dim) { }
       
        public double Area()
        {
            return dim1 * dim2;
        }
    }
}
