// namespace - to organize where the code is located and it encapsulate the program's logic
namespace HelloWorld {
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            // declare a (string variable) variable
            string myFriendsName;
            // assign a value to the myFriendsName variable
            myFriendsName = "Jannick";
            Console.WriteLine(myFriendsName);
            myFriendsName = "Frank";
            Console.WriteLine(myFriendsName);
            // use that variable
            Console.ReadKey();
        }
    }
}