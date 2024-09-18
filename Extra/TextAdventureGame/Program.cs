Game.Start();

public static class Game
{
    public static void Start()
    {
        Console.WriteLine("Welcome to the Adventure Game!");
        string charName = CharacterName();
        string charType = CharacterType();
        Console.WriteLine($"You, {charName} the {charType} find yourself at the edge of a dark forest");
        FirstChoice();
        SecondChoice();
    }

    public static string CharacterName()
    {
        Console.WriteLine("Enter your character's name");
        return Console.ReadLine();
    }

    public static string CharacterType()
    {
        Console.WriteLine("Choose your character type (Warrior, Wizard, Archer)");
        return Console.ReadLine();

    }
    public static void FirstChoice()
    {
        Console.WriteLine("Do you enter the forest or camp outside? (Enter/Camp)");
        string choice1 = Console.ReadLine();
        if (choice1.ToLower() == "enter")
        {
            Console.WriteLine("You bravely enter the forest");
        }
        else
        {
            Console.WriteLine("You decided to camp out and wait for daylight.");
        }
    }

    public static void SecondChoice()
    {
        bool gameContinues = true;

        while (gameContinues)
        {
            Console.WriteLine("You come to a fork in the road. Go left or right ?");
            string direction = Console.ReadLine();
            if (direction.ToLower() == "left")
            {
                Console.WriteLine("You find a treasure chest!");
                gameContinues = false;
            }
            else
            {
                Console.WriteLine("You encounter a wild beast!");
                Console.WriteLine("Fight or flee? (fight/flee)");
                string fightChoice = Console.ReadLine();
                if (fightChoice.ToLower() == "fight") gameContinues = !Combat();
            }
        }
    }


    public static bool Combat()
    {
        bool die = false;
        Random random = new Random();
        int luck = random.Next(1, 11);
        if (luck > 5)
        {
            Console.WriteLine("You beat the wild beast!");
            if (luck > 8)
            {
                Console.WriteLine("The wild beast dropped a teasure!");
            }
        }
        else
        {
            Console.WriteLine("The beast attacked you where you didn't expected it");
            Console.WriteLine("It rammed it's tusk into your chest and you die");
            die = true;
        }
        return die;
    }
}

