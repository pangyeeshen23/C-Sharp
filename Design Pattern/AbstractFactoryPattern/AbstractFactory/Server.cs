using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactory
{
    public class Server : Computer
    {
        private string _cpu;
        private string _hdd;
        private string _ram;
        private string _type;

        public Server(string cpu, string hdd, string ram)
        {
            this._cpu = cpu;
            this._hdd = hdd;
            this._ram = ram;
            this._type = "Server";
        }

        public override string getCPU()
        {
            return _cpu;
        }

        public override string getHDD()
        {
            return _hdd;
        }

        public override string getRAM()
        {
            return _ram;
        }

        public override string getType()
        {
            return _type;
        }
    }
}
