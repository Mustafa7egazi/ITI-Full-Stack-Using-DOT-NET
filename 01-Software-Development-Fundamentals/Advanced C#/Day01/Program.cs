namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter first point coordinates speprated by space: ");
            string []firstCoords = Console.ReadLine().Split();

            Point p1 = new Point(int.Parse(firstCoords[0])
                ,int.Parse(firstCoords[1])
                ,int.Parse(firstCoords[2]));


            Console.Write("Enter second point coordinates speprated by space: ");
            string[] secondCoords = Console.ReadLine().Split();


            Point p2 = new Point(int.Parse(secondCoords[0]),
               int.Parse(secondCoords[1]),
                int.Parse(secondCoords[2]));


            Point[] ourPoints = [p1, p2];


            Console.WriteLine($"First coords: {ourPoints[0]}");
            Console.WriteLine($"Second coords: {ourPoints[1]}");

            if (p1.Equals(p2))
            {
                Console.WriteLine("Are Equals");
            }
            else
            {
                Console.WriteLine("Are not Equals");
            }

        }
    }
}
