using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory.Computer
{
    public class PC : Computer
    {
        private string _ram;
        private string _hdd;
        private string _cpu;
        private string _type;

        public PC(string ram, string hdd, string cpu)
        {
            _ram = ram;
            _hdd = hdd;
            _cpu = cpu;
            _type = "PC";
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
