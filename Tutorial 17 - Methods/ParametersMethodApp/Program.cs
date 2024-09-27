
static int AddTwoValues(int value1, int value2)
{
    int result = value1 + value2;
    return result;
}

static int SubtractTwoValues(int value1, int value2)
{
    int result = (value1 - value2);
    return result;
}

Console.WriteLine("Enter a number, I'll add 10 to it!");
int num1 = int.Parse(Console.ReadLine());
int result = AddTwoValues(num1, 10);
int result2 = SubtractTwoValues(num1, 5);
Console.WriteLine("Result is " + result);
Console.WriteLine("Result 2 is " + result2);
Console.ReadKey();