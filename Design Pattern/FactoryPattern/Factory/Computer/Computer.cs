using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory.Computer
{
    public abstract class Computer
    {
        public abstract string getRam();
        public abstract string getHDD();
        public abstract string getCPU();
        public abstract string getType();

        public string toString()
        {
            return "Type= "+ getType() +", RAM=" + getRam() + ", HDD=" + getHDD() + ", CPU=" + getCPU();
        }
    }
}
