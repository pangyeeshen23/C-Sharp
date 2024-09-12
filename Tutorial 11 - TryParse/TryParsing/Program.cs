// creating a instance of the Random class
Random random = new Random();
// this will give us a random number between 1 and 10
int randomNumber = random.Next(1, 11);

Console.WriteLine("Guess the number");
string input = Console.ReadLine();

bool isNumber = int.TryParse(input, out int num1);
if (isNumber)
{
    if(num1 == randomNumber) Console.WriteLine("You guessed right !");
    else Console.WriteLine("You guessed wrong, try again !");
}
else
{
    Console.WriteLine("Haha, you troll you should've entered a number");
}

num1++;
Console.WriteLine("Number + 1 is {0}", num1);
