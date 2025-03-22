using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignmentDay06.Inheritance_Models
{
    internal class Triangle:Shape
    {
        public Triangle(double triBase , double height):base(triBase,height) { }
        public double Area()
        {
            return 0.5 * dim1 * dim2;
        }
    }
}
