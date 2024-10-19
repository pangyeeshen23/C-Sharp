namespace Tutorial_19___Named_Parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddNum(15, 21));
            Console.WriteLine(AddNum(firstNum: 23, secondNum: 25));
            Console.WriteLine(AddNum(firstNum: 15, 25));
            Console.WriteLine(AddNum(15, secondNum: 25));
            Console.WriteLine("Hello, World!");
        }

        static int AddNum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
