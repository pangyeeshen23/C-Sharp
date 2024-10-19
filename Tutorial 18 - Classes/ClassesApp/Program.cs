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

            // accessing the public static variable NumberOfCars
            Console.WriteLine("Number of cars produced: " + Car.NumberOfCar);
       

            Customer earl = new Customer("Earl");
            Customer frank = new Customer("FrankTheTank", "Mainstreet", "555121311");

            Customer myCustomer = new Customer();
            Console.WriteLine("Please enter the customers here");
            myCustomer.SetDetails("Frank", "Mainstreet 2");
            
            Console.WriteLine("My Customer is " + myCustomer.Name + " and he lives in " + myCustomer.Address);
            Console.WriteLine("Earl is "+ earl.Name + " and he lives in " + earl.Address);


            Customer customer1 = new Customer("Frank");
            Console.WriteLine("Contact Number of Frank is : " + customer1.ContactNumber);


            //Static Method
            Customer.DoSomeCustomerStuff();
            MyMethod();
            Console.WriteLine();
            Console.ReadKey();
        }

        static void MyMethod()
        {
            Console.WriteLine("My Method");
        }
    }
}
