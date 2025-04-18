using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarificationAndPercision
{
    class Braces
    {
        public void Main()
        {
            // bad 
            bool isValid = true;
            if (isValid)
                Console.WriteLine("Valid");


            foreach(int i in new int[1, 2, 3])
                Console.WriteLine(i);

            // good
            if (isValid)
            {
                Console.WriteLine("Valid");
            }
              
            foreach (int i in new int[1, 2, 3])
            {
                Console.WriteLine(i);
            }
        }
    }
}
