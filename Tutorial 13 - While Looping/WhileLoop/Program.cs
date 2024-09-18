// The while loop
//Console.WriteLine("Enter go or stay");
//string userChoice = Console.ReadLine();
//while(userChoice == "go")
//{
//    Console.WriteLine("Walk for a mile");
//    Console.WriteLine("Wanna keep going? Enter go.");
//    userChoice = Console.ReadLine();
//}
//Console.WriteLine("Finally you are staying!");


Console.WriteLine("Guess the number I'm thinking of between 1 and 100");
int userGuessedNumber = 0;
int secretNumber = new Random().Next(1,101);
int counter = 0;
while (userGuessedNumber != secretNumber)
{
    counter++;
    Console.WriteLine("Enter your guess");
    userGuessedNumber = int.Parse(Console.ReadLine());
    if (userGuessedNumber < secretNumber)
    {
        Console.WriteLine("Too low! Try again.");
    }
    else if (userGuessedNumber > secretNumber)
    {
        Console.WriteLine("Too high! Try again.");
    }
    else
    {
        Console.WriteLine("Congratulations! You guessed the number right! It took you " + counter + " tries!");
    }
}