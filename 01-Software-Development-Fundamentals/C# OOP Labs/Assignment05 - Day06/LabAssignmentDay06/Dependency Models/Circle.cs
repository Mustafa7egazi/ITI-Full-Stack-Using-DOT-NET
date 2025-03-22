namespace LabAssignmentDay06.Dependency_Models
{
    internal class Circle
    {
        private double radius;
        private Point centerOfCircle;

        public double Radius { get { return radius; } set { radius = value; } }
        public Point CenterOfCircle { get { return centerOfCircle; } set { centerOfCircle = value; } }

        public Circle()
        {
            radius = 0.0;
            centerOfCircle = new Point();
            Console.WriteLine("---- Default Ctor in Circle ----");
        }

        public Circle(double _raduis, int x, int y)
        {
            radius = _raduis;
            centerOfCircle = new Point(x, y);
            Console.WriteLine("---- Parametarized Ctor in Circle ----");
        }

        public string Print()
        {
            return $"Circle is centered at {centerOfCircle.Print()}, with radius of {radius} cm";
        }

    }
}
