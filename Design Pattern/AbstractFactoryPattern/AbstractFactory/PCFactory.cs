using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactory
{
    public class PCFactory : ComputerAbstractFactory
    {
        private string _ram;
        private string _hdd;
        private string _cpu;

        public PCFactory(string ram, string hdd, string cpu)
        {
            this._ram = ram;
            this._hdd = hdd;
            this._cpu = cpu;
        }

        public Computer createComputer()
        {
            return new PC(this._ram, this._hdd, this._cpu);
        }
    }
}
