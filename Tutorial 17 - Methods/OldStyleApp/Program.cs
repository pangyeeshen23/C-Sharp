namespace OldStyleApp
{
    internal class Program
    {
        // Field  (or instance variable - sometimes even called global variables)
        private static int myResult;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number, I'll add 10 to it!");
            int num1 = int.Parse(Console.ReadLine());
            myResult = AddTwoValues(num1, 10);
            Console.WriteLine("The Result is " + myResult);

            ChildProgram childProgram = new ChildProgram();
            childProgram.Process();
        }

        public static void ShowMessage()
        {
            Console.WriteLine("Hello");
        }

        static int AddTwoValues(int value1, int value2)
        {
            myResult = value1 + value2;
            return myResult;
        }

        static int SubtractTwoValues(int value1, int value2)
        {
            myResult = (value1 - value2);
            return myResult;
        }
    }

    public class ChildProgram
    {
        public void Process()
        {
            Program.ShowMessage();
        }
    }
}
