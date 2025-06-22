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
