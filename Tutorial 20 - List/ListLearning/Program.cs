namespace ListLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring a list and initializing
            //List<string> colors = ["red", "blue", "green", "yellow", "red"];

            //Console.WriteLine("Current colors in the color list");
            //foreach (string color in colors)
            //{
            //    Console.WriteLine(color);
            //}

            //bool isDeletingSuccessful = colors.Remove("red");
            //while (isDeletingSuccessful)
            //{
            //    isDeletingSuccessful = colors.Remove("red");
            //}   

            //colors.Remove("red");
            //foreach (string color in colors)
            //{
            //    Console.WriteLine(color);
            //}

            List<int> numbers = new List<int>() { 10, 5, 15, 3, 9, 19, 25 };
            //Console.WriteLine("Unsorted List");
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //numbers.Sort();
            //Console.WriteLine("Sorted List");
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            ////Predicate<int> isGreaterThanTen = x => x > 10;
            //List<int> numGreaterThanTen = numbers.FindAll(IsGreaterThanTen);
            //Console.WriteLine("All number 10 and higher in out list numbers");
            //foreach (int number in numGreaterThanTen)
            //{
            //    Console.WriteLine(number);
            //}

            bool hasLargeNumber = numbers.Any(x => x > 30);
            if (hasLargeNumber)
            {
                Console.WriteLine("There are large numbers in the number");
            }
            else
            {
                Console.WriteLine("No large numbers in the list");
            }
        }

        public static bool IsGreaterThanTen(int x)
        {
            return x > 10;
        }
    }
}
