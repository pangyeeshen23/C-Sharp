namespace StructDemo
{
    // Stuct is a value type
    public struct Point
    {
        // best practice, Is to have the properties/field to be readonly fields
        //public double X { get; }
        //public double Y { get; }

        public double X { get; set; }
        public double Y { get; set;  }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point other)
        {
            double dx = other.X - X;
            double dy = other.Y - Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public void Display()
        {
            Console.WriteLine($"Point: ({X}, {Y})");
        }
    }

    public class PointClass
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointClass(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Display()
        {
            Console.WriteLine($"Point: ({X}, {Y})");
        }
    }

    internal class Program
    {   
        static void Main(string[] args)
        {
            Point point = new Point(10 , 20);
            Point point2 = point;
            point2.X = 50;
            Console.WriteLine("After changing point2.X to 50");
            point.Display();
            point2.Display();

            PointClass pC1 = new PointClass(1, 2);
            PointClass pC2 = pC1;
            pC1.Display();
            pC2.Display();

            pC2.X = 3;
            Console.WriteLine("After changing pC2.X to 3");
            pC1.Display();
            pC2.Display();

            bool isEqual = pC1.Equals(pC2.X);
            Console.WriteLine("Is it equal? " + isEqual);

            //Point point3 = point;
            //point3.Display();

        }
    }
}
