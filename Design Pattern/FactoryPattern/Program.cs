using FactoryPattern.Factory.Computer;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer pc = ComputerFactory.getComputer("PC","Corairs", "ADATA", "Intel");
            Console.WriteLine(pc.toString());

            Computer server = ComputerFactory.getComputer("Server", "Acer", "ADATA", "AMD");
            Console.WriteLine(server.toString());
        }
    }
}
