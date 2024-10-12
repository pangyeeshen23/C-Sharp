using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactory
{
    public class ComputerFactory
    {
        public static Computer getComputer(ComputerAbstractFactory factory)
        {
            return factory.createComputer();
        }
    }
}
