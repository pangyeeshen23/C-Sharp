namespace DelegatesDemo
{
    internal class Program
    {
        // 1. Delegates
        // it can be declare inside of a class or out side of a class, but depend on usage
        // it is recommended to declare the delegate outside of the class
        public delegate void Notify(string message);

        static void Main(string[] args)
        {
            // 2. Instantiation
            Notify notifyDelegate = ShowMessage;
            //Notify notifyDelegate = new Notify(notifyDelegate);

            // 3. Invocation
            notifyDelegate("Hello Delegates !");

            LoggerDemo logger = new LoggerDemo();
            LogHandler logHandler = logger.LogToConsole;
            logHandler("Logging to Console");

            logHandler = logger.LogToFile;
            logHandler("Logging to File");

            int[] intArray = { 1, 2, 3, 4, 5 };
            SortingAlgo.PrintArray(intArray);
            string[] strings = { "One", "Two", "Three", "Four" };
            SortingAlgo.PrintArray(strings);

            SortingAlgo algo = new SortingAlgo();
            algo.Process();
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
