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
            //logHandler += logger.LogToFile;
            logHandler("Logging to Console");

            foreach(LogHandler handler in logHandler.GetInvocationList())
            {
                try
                {
                    handler("Event occured with error handling");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught: " + ex.Message);
                }
            }

            if (IsMethodInDelegate(logHandler, logger.LogToFile))
            {
                logHandler -= logger.LogToFile;
            }
            else
            {
                Console.WriteLine("Log to File Function Not Found");
            }
            //logHandler("After removing log to file");

            InvokeSafely(logHandler, "Logging to Console");
            //logHandler = logger.LogToFile;
            //logHandler("Logging to File");

            //int[] intArray = { 1, 2, 3, 4, 5 };
            //SortingAlgo.PrintArray(intArray);
            //string[] strings = { "One", "Two", "Three", "Four" };
            //SortingAlgo.PrintArray(strings);

            //SortingAlgo algo = new SortingAlgo();
            //algo.Process();
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void InvokeSafely(LogHandler logHandler, string message)
        {
            LogHandler tempLogHandler = logHandler;
            if (tempLogHandler != null) tempLogHandler(message);
        }

        static bool IsMethodInDelegate(LogHandler logHandler, LogHandler method)
        {
            if(logHandler == null) return false;
            foreach(var d in logHandler.GetInvocationList())
            {
                if(d == (Delegate)method) return true;
            }
            return false;
        }
    }
}
