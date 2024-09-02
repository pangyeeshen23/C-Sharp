// See https://aka.ms/new-console-template for more information
int num = 10;
double price = 19.95;
string name = "Frank";

// Interpolation
Console.WriteLine($"The number is {num}");
//String Concatination
Console.WriteLine("The number is " + num);

Console.WriteLine(@"The number is ""num""
 Number ");
Console.WriteLine(@"C:\Users\scolderidge\Document");


//String Formating
Console.WriteLine("The number is {0} and the price is {1}, and the name is {2}", num, price, name);
