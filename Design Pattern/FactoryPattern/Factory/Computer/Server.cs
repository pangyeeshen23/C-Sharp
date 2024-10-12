using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory.Computer
{
    public class Server : Computer
    {

        private string _ram;
        private string _hdd;
        private string _cpu;
        private string _type;

        public Server(string ram, string hdd, string cpu)
        {
            _ram = ram;
            _hdd = hdd;
            _cpu = cpu;
            _type = "Computer";
        }

        public override string getCPU()
        {
            return _cpu;
        }

        public override string getHDD()
        {
            return _hdd;
        }

        public override string getRam()
        {
            return _ram;
        }

        public override string getType()
        {
            return _type;
        }
    }
}
