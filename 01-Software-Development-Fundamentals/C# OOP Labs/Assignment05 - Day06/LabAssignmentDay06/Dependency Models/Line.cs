using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignmentDay06.Dependency_Models
{
    internal class Line
    {
        private Point startPoint = new Point();
        private Point endPoint = new Point();

        public Point StartPoint { get { return startPoint; } set { startPoint = value; } }
        public Point EndPoint { get { return endPoint; } set { endPoint = value; } }



        public Line()
        {
            
            startPoint.X = 0;
            startPoint.Y = 0;
            endPoint.X = 0;
            endPoint.Y = 0;
            Console.WriteLine("---- Default Ctor in Line ----");
        }

        public Line(int x1, int y1 , int x2, int y2)
        {
            startPoint.X = x1;
            startPoint.Y = y1;
            endPoint.X = x2;
            endPoint.Y = y2;
            Console.WriteLine("---- Paramertized Ctor in Line ----");
        }

        public string Print()
        {
            return $"Line drawn from point 1: {startPoint.Print()} TO point 2: {endPoint.Print()}";
        }
    }
}
