namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myAudi = new Car("A3", "Audi", false);
            myAudi.Drive();

            Car myBmw = new Car("i7", "BMW", true);
            myBmw.Drive();

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
