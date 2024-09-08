// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int num1 = 0;
int num2 = 0;

// relational operator  < <= > >=
bool isGreater = num1 > num2;
bool isEqual = num1 == num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("Please enter a whole number");
if (num1 == int.Parse(Console.ReadLine()))
{
    Console.WriteLine("Numbers are equal!");
    Console.WriteLine("Please enter your age");
    int age = int.Parse(Console.ReadLine());
    if(age >= 18)
    {
        Console.WriteLine("Please enter your address, " +
            "so that we can send you the price!");
        string address = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Sorry you can't get your price due to your age!");
    }
}
else
{
    Console.WriteLine("Number are not equal!");
}


//int age = 22;
//bool isWithParent = false;

//if (age >= 13 && isWithParent)
//{
//    Console.WriteLine("Go party in the club with your parents!");
//}
//else if (age > 18)
//{
//    Console.WriteLine("Go party in the club!");
//}
//else
//{
//    Console.WriteLine("Go party in the kindergarden!");
//}

//bool isRainy = true;
//bool hasUmbrella = true;

//if (isRainy && !hasUmbrella)
//{
//    Console.WriteLine("I'm getting wet!");
//}

Console.WriteLine("Ay OK!");