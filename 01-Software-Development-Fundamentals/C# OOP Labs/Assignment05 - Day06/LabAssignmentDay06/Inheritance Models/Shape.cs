using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignmentDay06.Inheritance_Models
{
    internal class Shape
    {
        protected double dim1;
        protected double dim2;
        public double Dim1 { get { return dim1; } set { dim1 = value; } }
        public double Dim2 { get { return dim2; } set { dim2 = value; } }

        public Shape()
        {
            dim1 = 0;
            dim2 = 0;
            Console.WriteLine("Shap def ctor");
        }

        public Shape(double dim1, double dim2)
        {
            this.dim1 = dim1;
            this.dim2 = dim2;
            Console.WriteLine("Shap 2p ctor");
        }

        public Shape(double dim)
        {
            dim1 = dim2 = dim;
            Console.WriteLine("Shap 1p ctor");
        }
    }
}
