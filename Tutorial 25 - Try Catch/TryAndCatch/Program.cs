namespace TryAndCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int result = 0;


            try
            {
                Console.WriteLine("Please enter a number");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = 2;
                result = num2 / num1;
            }
            catch (Exception ex)
            {
                ex.ToString();
                Console.WriteLine("Error: "+ ex.Message);
            }
            finally
            {
                // code to cleanup or finalize
                // ideal for cleaning up resources
                Console.WriteLine("This always executes");
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
