using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTutorial
{
    internal class Logger
    {
        public void Log<T>(T value)
        {
            Console.WriteLine($"Value is : {value}");
        }
    }
}
