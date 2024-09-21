for (int i = 0; i < 10; i ++)
{
    Console.WriteLine(i);
    if (i == 3)
    {
        //Console.WriteLine("I've had enough!");
        //break;
        continue;
    }
    Console.WriteLine("Only if not continued");
}
