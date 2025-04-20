using GenericsTutorial.Interfaces;
using GenericsTutorial.RealWorldExample;
using GenericsTutorial.Repository;

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


            IRepository<Stuff> productRepository = new StuffRepository();
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
