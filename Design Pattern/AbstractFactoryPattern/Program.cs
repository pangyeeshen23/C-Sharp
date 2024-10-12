using AbstractFactoryPattern.AbstractFactory;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer pc = ComputerFactory.getComputer(new PCFactory("8GB", "1TB", "Intel"));
            Computer server = ComputerFactory.getComputer(new ServerFactory("4GB", "2TB", "AMD"));

            Console.WriteLine(pc.ToString());
            Console.WriteLine(server.ToString());
        }
    }
}
