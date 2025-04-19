using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarificationAndPercision.SOLID
{
    // Interface Segregation Principle (ISP)
    class InterfaceSegegrationPrinciple
    {
        public static void Main()
        {
            Human human = new Human();
            human.Work();
            human.Eat();

            Robot robot = new Robot();
            robot.Work();

        }
    }

    // At first both, robot and human has implemented the IWorker interface
    // but the robot does not need to implement the Eat method
    // so we have to segregate the interface into two interfaces
    // IWorkable and IEatable

    public interface IWorker
    {
        void Work();
        void Eat();
    }

    public interface IEatable
    {
        void Eat();
    }

    public interface IWorkable
    {
        void Work();
    }

    public class Human : IWorkable, IEatable
    {
        public void Work()
        {
            Console.WriteLine("Human is working");
        }
        public void Eat()
        {
            Console.WriteLine("Human is eating");
        }
    }

    public class Robot : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Robot is working");
        }
    }
}
