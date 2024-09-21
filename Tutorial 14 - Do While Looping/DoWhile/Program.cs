
int currentScore;
int sum = 0;
int counter = 0;
// do-while loop is a post-test loop

do
{
    Console.WriteLine("Enter your students score. Enter -1 to finish !");
    currentScore = int.Parse(Console.ReadLine());
    if (currentScore == -1) continue;
    sum = sum + currentScore;
    counter++;
} while (currentScore != -1);

int average = sum / counter;
Console.WriteLine("Sum is : " + sum);
Console.WriteLine("Average is : " + average);
Console.WriteLine("Finally");