namespace LabAssignmentDay06.Dependency_Models
{
    internal class Point
    {
        private int x;
        private int y;

        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }


        public Point()
        {
            x = 0;
            y = 0;
            Console.WriteLine("---- Default CTOR in point ----");
        }

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
            Console.WriteLine("---- Prameterized CTOR in point ----");
        }

        public string Print()
        {
            return $"({x},{y})";
        }


    }
}
