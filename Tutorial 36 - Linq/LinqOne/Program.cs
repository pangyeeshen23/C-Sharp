int[]number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
OddNumbers(number);
Console.ReadKey();

static void OddNumbers(int[] numbers)
{
    Console.WriteLine("Odd Numbers: ");
    IEnumerable<int> oddNumbers = from number in numbers
                                  where number % 2 != 0
                                  select number;
    Console.WriteLine(oddNumbers);
    foreach(int number in oddNumbers)
    {
        Console.WriteLine(number);
    }
}