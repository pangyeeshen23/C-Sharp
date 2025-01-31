namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "This is a log entry";
            ILogger fileLogger = new FileLogger();
            fileLogger.Log(message);
            Application application = new Application(fileLogger);
            application.DoWork(message);

            ILogger databaseLogger = new DatabaseLogger();
            Application dbApplication = new Application(databaseLogger);
            dbApplication.DoWork(message);
        }
    }

    public class Application
    {
        private readonly ILogger _logger;
        public Application(ILogger logger)
        {
            _logger = logger;
        }

        public void DoWork(string message)
        {
            _logger.Log("Work Started");
            // Do All The Work!
            _logger.Log("Work Done");
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging to database. {message}");
        }
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            string directoryPath = @"C:\Logs";
            string filePath = Path.Combine(directoryPath, "log.txt");
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(filePath);
            }
            File.AppendAllText(filePath, message + "\n");
        }
    }
}
