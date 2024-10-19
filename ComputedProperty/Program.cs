namespace ComputedProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.Width = 5;
            r1.Height = 5;
            Console.WriteLine("Area of r1 is " + r1.Area);
        }
    }
}
