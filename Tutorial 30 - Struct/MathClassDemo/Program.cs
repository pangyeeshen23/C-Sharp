﻿namespace MathClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ceiling: " + Math.Ceiling(15.3));
            Console.WriteLine("Flooring: " + Math.Floor(15.3));

            int num1 = 13;
            int num2 = 9;
            Console.WriteLine("Lower of num1 {0} and num2 {1} is {2}", num1, num2, Math.Min(num1, num2));
            Console.WriteLine("Higher of num1 {0} and num2 {1} is {2}", num1, num2, Math.Max(num1, num2));

            Console.WriteLine("3 to the the power 5 is {0}", Math.Pow(3, 5));
            Console.WriteLine("PI is: {0}", Math.PI);

            Console.WriteLine("The square root of 25 is {0}", Math.Sqrt(25));
            Console.WriteLine("Always positive is {0}", Math.Abs(-25));
            Console.WriteLine("Cos of 1 is: {0}", Math.Cos(1));

            Exercise exercise = new Exercise();
            exercise.TestEvents();
        }

    }
}
