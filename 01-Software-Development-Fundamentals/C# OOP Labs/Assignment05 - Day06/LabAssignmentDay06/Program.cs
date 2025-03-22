
namespace LabAssignmentDay06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("================== Lab Assignment - Day06 ====================");
            Console.WriteLine("==============================================================");


            #region Task01 - Try Association
            /* First Association */
            //Console.WriteLine("\n\n\n======================= Triangle Example #1  =====================");
            //Point p1 = new Point();
            //Point p2 = new Point(3, 4);
            //Point p3 = new Point(6, 7);

            //Triangle triangle = new Triangle();

            //triangle.FirstPoint = p1;
            //triangle.SecondPoint = p2;
            //triangle.ThirdPoint = p3;

            //Console.WriteLine(triangle.Print());

            //// Removing association
            //triangle.FirstPoint = null;
            //triangle.SecondPoint = null;
            //triangle.ThirdPoint = null;

            //Console.WriteLine("\n\n\n======================= Triangle Example #2 =====================");

            //triangle = new Triangle(new Point(1,2),new Point(3,4) , new Point(5,6));
            //Console.WriteLine(triangle.Print());


            //Console.WriteLine("\n\n\n======================= Circle Example #1 =====================");
            //Point center = new Point(5,5);
            //Circle circle = new Circle();
            //circle.Radius = 4;
            //circle.CenterOfCircle = center;
            //Console.WriteLine(circle.Print());

            #endregion

            #region Task02 - Try Composition
            /*  Second Composition */
            //Console.WriteLine("\n\n\n======================= Line Example #1  =====================");
            //Line defaultLine = new Line();
            //Line customLine = new Line(3, 4, 9, 10);
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine(defaultLine.Print());
            //Console.WriteLine(customLine.Print());

            //Console.WriteLine("\n\n\n======================= Rectangle Example #2  =====================");
            //Rectangle rectangle = new Rectangle(4,5,8,9);
            //Console.WriteLine(rectangle.Print());

            //Console.WriteLine("-----------------------------");


            #endregion

            #region Task03 - Try Inheritance

            //Inheritance_Models.Rectangle rectangle = new Inheritance_Models.Rectangle(4,3);
            //Console.WriteLine($"Rectangle Area: Length x width = {rectangle.Dim1} x {rectangle.Dim2} = {rectangle.Area()}");
            //Console.WriteLine("\n====================================================\n");
            //Inheritance_Models.Square square = new Inheritance_Models.Square(4);
            //Console.WriteLine($"Square Area: Length x width = {square.Dim1} x {square.Dim2} = {square.Area()}");
            //Console.WriteLine("\n====================================================\n");
            //Inheritance_Models.Circle circle = new Inheritance_Models.Circle(5);
            //Console.WriteLine($"Circle Area:  π r2 = π x {circle.Dim1} x {circle.Dim2} = {circle.Area()}");
            //Console.WriteLine("\n====================================================\n");
            //Inheritance_Models.Triangle triangle = new Inheritance_Models.Triangle(6,3);
            //Console.WriteLine($"Triangle Area:  0.5 x Base x height  = 0.5 x {triangle.Dim1} x {triangle.Dim2} = {triangle.Area()}");

            #endregion
        }
    }
}
