using System.Diagnostics;

namespace TryAndCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int result = 0;

            Debug.WriteLine("Main method is runing");

            try
            {
                Console.WriteLine("Please enter a number");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = 2;
                result = num2 / num1;

                //Console.WriteLine("Please enter your age");
                //GetUserAge(Console.ReadLine());
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Don't Divide By Zero !! " + ex.Message);
                result = 10;
                Debug.WriteLine(ex.ToString());
            }
            catch(FormatException ex)
            {
                Console.WriteLine("I TOLD YOU ENTER A NUMBER !! " + ex.Message);
                Debug.WriteLine(ex.ToString());
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Number to high");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: "+ ex.Message);
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                // code to cleanup or finalize
                // ideal for cleaning up resources
                Console.WriteLine("This always executes");
            }

            Console.WriteLine("Result: " + result);
        }

        static int GetUserAge(string input)
        {
            int age;
            if (!int.TryParse(input, out age))
            {
                throw new Exception("You didn't enter a valid age.");
            }
            if(age < 0 || age > 120)
            {
                throw new Exception("Your age must be between 0 and 120.");
            }
            return age;
        }
    }

}
