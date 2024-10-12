using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory.Computer
{
    public class ComputerFactory
    {
        public static Computer getComputer(string type, string ram, string hdd, string cpu)
        {
            if (type == "PC")
            {
                return new PC(ram, hdd, cpu);
            }
            else if (type == "Server")
            {
                return new Server(ram, hdd, cpu);
            }

            return null;
        }
    }
}
