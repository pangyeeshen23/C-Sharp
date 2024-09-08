// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//int num1 = 0;
//int num2 = 0;
//int age = 0;

//// relational operator  < <= > >=
//bool isGreater = num1 > num2;
//bool isEqual = num1 == num2;
//bool isNotEqual = num1 != num2;

//Console.WriteLine("Please enter a whole number");
//if (num1 == int.Parse(Console.ReadLine()))
//{
//    Console.WriteLine("Numbers are equal!");
//    Console.WriteLine("Please enter your age");
//    age = int.Parse(Console.ReadLine());
//    if(age >= 18)
//    {
//        Console.WriteLine("Please enter your address, " +
//            "so that we can send you the price!");
//        string address = Console.ReadLine();
//    }
//    else
//    {
//        Console.WriteLine("Sorry you can't get your price due to your age!");
//    }
//}
//else
//{
//    Console.WriteLine("Number are not equal!");
//}

//age = 0;
Console.WriteLine("How old are you ?");
int age = int.Parse(Console.ReadLine());
bool isWithParent = false;

if(age > 18)
{
    Console.WriteLine("Go party in the club!");
}
else if (age >= 13)
{
    Console.WriteLine("Are you with you parents ? Answer with y or n");
    if(Console.ReadLine() == "y") isWithParent = true;
    if(isWithParent) Console.WriteLine("Go party in the club with your parents!");
    else Console.WriteLine("No party for you today");
}
else
{
    Console.WriteLine("Go party in the kindergarden!");
}

bool isRainy = true;
bool hasUmbrella = true;

if (isRainy && !hasUmbrella)
{
    Console.WriteLine("I'm getting wet!");
}

Console.WriteLine("Ay OK!");