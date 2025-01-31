namespace DependencyInjectionApp
{
    public class Hammer
    {
        public void Use()
        {
            Console.WriteLine("Hammering Nails !");
        }
    }

    public class Saw
    {
        public void Use()
        {
            Console.WriteLine("Sawing wood !");
        }
    }

    public class Builder
    {
        public Hammer Hammer { get; set; }
        public Saw Saw { get; set; }

        //private Hammer _hammer;
        //private Saw _saw;

        // Constructur Dependency Injector (DI)
        //public Builder(Hammer hammer, Saw saw)
        //{
        //    _hammer = hammer;
        //    _saw = saw; 
        //}

        public void BuildHouse()
        {
            Hammer.Use();
            Saw.Use();
            Console.WriteLine("House build");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Hammer hammer = new Hammer();
            //Saw saw = new Saw();
            //Builder builder = new Builder(hammer, saw);

            Builder builder = new Builder();
            builder.Hammer = new Hammer(); // Inject dependencies via Setters
            builder.Saw = new Saw(); // Inject dependencies via Setters
            builder.BuildHouse();
            Console.WriteLine("Hello, World!");
        }
    }
}
