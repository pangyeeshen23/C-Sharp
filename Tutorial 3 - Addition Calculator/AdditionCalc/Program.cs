// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Enter the first number");
string firstNumber = Console.ReadLine();
Console.WriteLine("Enter the second number");
string secondNumber = Console.ReadLine();
double sum = Math.Round(double.Parse(firstNumber, CultureInfo.InvariantCulture) + double.Parse(secondNumber, CultureInfo.InvariantCulture),2);
Console.WriteLine($"The sum of {firstNumber.ToString(CultureInfo.InvariantCulture)} and {secondNumber.ToString(CultureInfo.InvariantCulture)} " +
    $"is: {sum.ToString(CultureInfo.InvariantCulture)}");

