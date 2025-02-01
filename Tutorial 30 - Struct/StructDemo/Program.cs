namespace StructDemo
{

    public struct Point
    {
        public int X;
        public int Y;
        //public int X { get; set; }
        //public int Y { get; set; }
        public Point(int x, int y)
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
            point.Display();

            Point point2;
            point2.X = 10;
            point2.Y = 20;
            point2.Display();
        }
    }
}
