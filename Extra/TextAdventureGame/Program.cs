new Game().Start();

Console.WriteLine("Game Over!");
Console.WriteLine("Thank you for playing the game!");

public class Game
{
    private string charType = "";
    public void Start()
    {
        Console.WriteLine("Welcome to the Adventure Game!");
        string charName = CharacterName();
        this.charType = CharacterType();
        Console.WriteLine($"You, {charName} the {charType} find yourself at the edge of a dark forest");
        bool wait = FirstChoice();
        if(!wait) SecondChoice();
    }

    public string CharacterName()
    {
        Console.WriteLine("Enter your character's name");
        return Console.ReadLine();
    }

    public string CharacterType()
    {
        Console.WriteLine("Choose your character type (Warrior, Wizard, Archer)");
        return Console.ReadLine();

    }
    public bool FirstChoice()
    {
        bool wait = false;
        Console.WriteLine("Do you enter the forest or camp outside? (Enter/Camp)");
        string choice1 = Console.ReadLine();
        if (choice1.ToLower() == "enter")
        {
            Console.WriteLine("You bravely enter the forest");
        }
        else
        {
            wait = true;
            Console.WriteLine("You decided to camp out and wait for daylight.");
        }
        return wait;
    }

    public void SecondChoice()
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


    public bool Combat()
    {
        bool die = false;
        Random random = new Random();
        int luck = random.Next(1, 11);
        if (this.charType == "Wizard" && luck > 2)
        {
            Win(luck);
        }
        else if (luck > 5)
        {
            Win(luck);
        }
        else
        {
            Console.WriteLine("The beast attacked you where you didn't expected it");
            Console.WriteLine("It rammed it's tusk into your chest and you die");
            die = true;
        }
        return die;
    }

    public void Win(int luck)
    {
        Console.WriteLine("You beat the wild beast!");
        if (luck > 8)
        {
            Console.WriteLine("The wild beast dropped a teasure!");
        }
    }
}
