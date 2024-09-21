
int number;

// do-while loop is a post-test loop

do
{
    Console.WriteLine("Enter a positive whole number");
    number = int.Parse(Console.ReadLine());
} while (number <= 0);
Console.WriteLine("Finally");