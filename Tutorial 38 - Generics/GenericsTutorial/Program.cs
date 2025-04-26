using GenericsTutorial.ConfigurationManager;
using GenericsTutorial.Interfaces;
using GenericsTutorial.RealWorldExample;
using GenericsTutorial.Repository;
using GenericsTutorial.TaskManagement;

namespace GenericsTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Box<int> box = new Box<int>(1);
            //box.Content = 1;
            //Console.WriteLine(box.Log());

            // Generic Class with Constructor
            //Box<string> stringBox = new Box<string>("Hello");
            //stringBox.Content = "Hello";
            //Console.WriteLine(stringBox.Log());

            // Generic Class with method
            //Box<string> boxStr = new Box<string>("Hello");
            //boxStr.UpdateContent("Learning C#");
            //Console.WriteLine(boxStr.GetContent());

            //Multi Generic Type
            //MultipleGenericType<int, string> multipleGenericType = new MultipleGenericType<int, string>(100, "one hundred");
            //multipleGenericType.Display();

            // Generic Method
            //Logger log = new Logger();
            //log.Log<decimal>(100);
            //log.Log(new { Name = "John", Age = 30 });


            // Generic Class with constraints
            //ConstraintsGen<Book> constraintsGen = new ConstraintsGen<Book>();

            // Repository Pattern - Real World Example
            //Repository<Product> productRepository = new Repository<Product>();
            //Product product = new Product();
            //productRepository.Add(product);


            // Generic method with constraints
            //var productOne = new Product();
            //var productTwo = new Product();

            //var result = Comparer.AreEqual(productOne, productTwo);
            //Console.WriteLine(result);


            //IRepository<Stuff> stuffRepository = new StuffRepository();

            // Reflections
            //string myName = "John Doe";
            //if (myName.GetType() == typeof(string))
            //{

            //}
            //Type type = typeof(ConfigurationManager<>);

            //Action
            //Action action = () => {
            //    Console.WriteLine("Hello World!");
            //};

            //Action<int> numPrint = (x) =>
            //{
            //    Console.WriteLine(x);
            //};

            //Action<float, float, float> sum = (x,y,z) =>
            //{
            //    Console.WriteLine(x + y + z);
            //};

            //action();
            //numPrint(100);
            //sum(25, 15, 20);

            //Func
            //Difference between Func and Action is that Func returns a value
            //Func<float, string> convertToString = (x) => { return x.ToString(); };
            //var number = convertToString(100);
            //Console.WriteLine(number);

            //Func<float, float, float> sumOfTwoNumbers = (x, y) => { return x + y; };
            //var sum = sumOfTwoNumbers(100, 200);
            //Console.WriteLine(sum);

            //Perdicate
            //it only return boolean
            //Predicate<int> isEven = (x) => { return x % 2 == 0; };
            //Console.WriteLine(isEven(4));

            //List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            //List<int> evenInts = ints.FindAll(isEven);

            //Task Processor
            EmailTask email = new EmailTask();
            email.Recipient = "Ethan";
            email.Message = "Email Task";
            ReportTask report = new ReportTask();
            report.ReportName = "Summary Report";
            TaskProcessor<EmailTask, string> taskProcessor = new TaskProcessor<EmailTask, string>(email);
            TaskProcessor<ReportTask, string> reportProcessor = new TaskProcessor<ReportTask, string>(report);
            string response = taskProcessor.Execute();
            string reportResponse = reportProcessor.Execute();
            Console.WriteLine(response);
            Console.WriteLine(reportResponse);
        }

        class Book
        {

        }

        class Product : IEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

    }
}
