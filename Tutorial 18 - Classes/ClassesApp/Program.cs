namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an object of the class Car
            // Creating an instance of the class Car
            Car audi = new Car("A3", "Audi", false);
            Car bmw = new Car("i7", "BMW", true);
            Console.WriteLine("Please enter the Brand name");
            Console.WriteLine("Brand is " + audi.Brand);
            Console.WriteLine("Brand is " + bmw.Brand);
        }
    }
}
