namespace Day01
{
    internal class Point
    {
        int x;
        int y;
        int z;


        public int X {
        
            get { return x; }
            set { x = value; }

        }
        public int Y { 
        
            get { return y; }
            set { y = value; }

        }

        public int Z { 
        
            get { return z; }
            set { z = value; }
        
        }

        public Point()
        {
            x = 0;
            y = 0;
            z = 0;
           
        }


        public Point(int firstD , int secondD , int thirdD)
        {
            X = firstD;
           Y = secondD; 
            Z = thirdD;

           
        }

        public override string ToString()
        {
           return $"Point coordinates: ({X},{Y},{Z})";
        }

        public override bool Equals(object? obj)
        {
            Point receivedPoint = obj as Point;
            return x == receivedPoint.x && y == receivedPoint.y && z == receivedPoint.z;
        }
    }
}
