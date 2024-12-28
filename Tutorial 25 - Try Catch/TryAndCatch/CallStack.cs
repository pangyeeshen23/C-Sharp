using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAndCatch
{
    public class CallStack
    {
        public void Main()
        {
            
            Console.WriteLine("App running before the try block");
            try
            {
                LevelOne();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception caught in Main: " + ex.Message);
            }
        }

        static void LevelOne()
        {
            LevelTwo();
        }

        static void LevelTwo()
        {
            Console.WriteLine("Level two before throw");
            throw new Exception("Something went wrong!");
            Console.WriteLine("Level two after throw");
        }
    }

}
