using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactory
{
    public abstract class Computer
    {
        public abstract string getRAM();
        public abstract string getHDD();
        public abstract string getCPU();

        public abstract string getType();

        public string ToString()
        {
            return "Type="+ this.getType() +", RAM=" + this.getRAM() + ", HDD=" + this.getHDD() + ", CPU=" + this.getCPU();
        }
    }
}
