string rocket = @" 
     /\
    /  \
   /____\
    |  |
    |  |
    |__|
   /    \
  /______\";

string landing = "\r\n" + "\r\n" + "\r\n" + "____________";
for (int counter = 10; counter >= 0; counter --)
{
    Console.Clear();
    Console.WriteLine("Counter is " + counter);
    rocket = "\r\n" + rocket;
    Console.WriteLine(rocket);
    if (counter <= 2)
    {
        int index = landing.IndexOf("\n");
        landing = landing.Remove(index, 1);
        Console.WriteLine(landing);
    }
    Thread.Sleep(1000);
}

Console.WriteLine("The Rocket has Landed!");
