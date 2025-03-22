using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignmentDay07
{
    abstract class Shape
    {
        protected double dim1;
        protected double dim2;
        public double Dim1 { get { return dim1; } set { dim1 = value; } }
        public double Dim2 { get { return dim2; } set { dim2 = value; } }



        public Shape()
        {
            dim1 = dim2 = 0;
        }
        public Shape(double _dim1, double _dim2)
        {
            dim1 = _dim1;
            dim2 = _dim2;
        }
        public Shape(double _dim)
        {
            dim1 = dim2 = _dim;
        }

        public abstract double Area();
    }

    class Rectangle : Shape
    {

        public Rectangle() { }
        public Rectangle(double _d1, double _d2) : base(_d1, _d2) { }
        public override double Area()
        {
            return dim1 * dim2;
        }
    }
    class Square : Shape
    {
        public Square() { }
        public Square(double dim) : base(dim) { }
        public override double Area()
        {
            return dim1 * dim2;
        }
    }


    class Circle : Shape
    {
        public Circle() { }
        public Circle(double _radius) : base(_radius) { }
        public override double Area()
        {
            return Math.PI * dim1 * dim2;
        }
    }
}
