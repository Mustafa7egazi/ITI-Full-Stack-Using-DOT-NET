using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignmentDay06.Dependency_Models
{
    internal class Triangle
    {
        private Point firstPoint;
        private Point secondPoint;
        private Point thirdPoint;

        public Point FirstPoint { get { return firstPoint; } set { firstPoint = value; } }
        public Point SecondPoint { get { return secondPoint; } set { secondPoint = value; } }
        public Point ThirdPoint { get { return thirdPoint; } set { thirdPoint = value; } }


        public Triangle()
        {
            firstPoint = new Point();
            secondPoint = new Point();
            thirdPoint = new Point();
            Console.WriteLine("---- Default Ctor in Triangle ----");
        }

        public Triangle(Point p1, Point p2, Point p3)
        {
            firstPoint = p1;
            secondPoint = p2;
            thirdPoint = p3;
            Console.WriteLine("---- Parametarized Ctor in Triangle ----");
        }

        public string Print()
        {
            return $"Triangle in between P1:({firstPoint.X},{firstPoint.Y})\n" +
                   $"                    P2:({secondPoint.X},{secondPoint.Y})\n" +
                   $"                    P3:({thirdPoint.X},{thirdPoint.Y})";
        }
    }
}
