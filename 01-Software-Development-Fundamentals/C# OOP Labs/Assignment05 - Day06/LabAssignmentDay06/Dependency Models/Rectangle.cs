using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignmentDay06.Dependency_Models
{
    internal class Rectangle
    {
        private Point upperLeftCorner;
        private Point lowerRightCorner;

        public Point UpperLeftCorner { get { return upperLeftCorner; } set { upperLeftCorner = value; } }
        public Point LowerRightCorner { get { return lowerRightCorner; } set { lowerRightCorner = value; } }

        public Rectangle()
        {
            upperLeftCorner = new Point();
            lowerRightCorner = new Point();
            Console.WriteLine("---- Default Ctor in Rectangle ----");
        }

        public Rectangle(int x1, int y1, int x2, int y2)
        {
            upperLeftCorner = new Point();
            lowerRightCorner = new Point();
            upperLeftCorner.X = x1;
            upperLeftCorner.Y = y1;
            lowerRightCorner.X = x2;
            lowerRightCorner.Y = y2;
            Console.WriteLine("---- Parameterized Ctor in Rectangle ----");
        }

        public string Print()
        {
            return $"Rectangle upper left corner {upperLeftCorner.Print()},and lower right corner {lowerRightCorner.Print()}";
        }
    }
}
