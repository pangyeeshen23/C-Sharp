using System.Numerics;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // in Operator
            int sumIn = 20;
            AdditionIn(10, 15, sumIn);
            Console.WriteLine(sumIn);

            // out Operator
            int sum;
            AdditionOut(10, 15, out sum);
            Console.WriteLine(sum);

            // ref Operator
            int sumRef = 0;
            AdditionRef(10, 25, ref sumRef);
            Console.WriteLine(sumRef);

            // is Operator
            bool isBools = true;
            if(isBools is bool) Console.WriteLine("IsBoolean");

            // as Operator
            object str = "Hello";
            object obj = 12;

            string message = str as string;
            string number = obj as string;

            if (message != null)
            {
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("str is not a string");
            }

            if (number != null)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("obj is not a string");
            }
        }

        public static void AdditionIn(int a, int b, in int sum)
        {
            // this code will give an error because sum is readonly
            // sum = a + b;
        }

        public static void AdditionOut(int a, int b, out int sum)
        {
            int sums = a + b;
            sum = sums;
        }

        public static void AdditionRef(int a, int b, ref int sum)
        {
            sum = a + b;
        }
    }
}
