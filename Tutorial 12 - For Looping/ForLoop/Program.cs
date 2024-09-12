// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// in strings \ is an "Escape Character"
// \n stands for "new line"
// \r stands fr carriage return

string myString = "Hi \r\nHi";
for (int counter = 5; counter <= 10; counter++)
{
    Console.WriteLine("Counter is " + counter);
    Console.WriteLine(myString);
    Thread.Sleep(1000);
}

for (int counter = 10; counter > 0; counter--)
{
    Console.WriteLine("Counter is " + counter);
}

Console.WriteLine("End Program");