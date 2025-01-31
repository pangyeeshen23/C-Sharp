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

    public interface IToolUser
    {
        void SetHammer(Hammer hammer);
        void SetSaw(Saw saw);
    }

    public class Builder : IToolUser
    {
        public Hammer Hammer { get; set; }
        public Saw Saw { get; set; }

        private Hammer _hammer;
        private Saw _saw;

        public Builder()
        {
            
        }

        //Constructur Dependency Injector(DI)
        public Builder(Hammer hammer, Saw saw)
        {
            _hammer = hammer;
            _saw = saw;
        }

        public void BuildHouse()
        {
            Hammer hammer = (Hammer != null) ? Hammer : _hammer;
            Saw saw = (Saw != null) ? Saw : _saw;
            _hammer.Use();
            _saw.Use();
            Console.WriteLine("House build");
        }

        public void SetHammer(Hammer hammer)
        {
            _hammer = hammer;
        }

        public void SetSaw(Saw saw)
        {
            _saw = saw;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Hammer hammer = new Hammer();
            //Saw saw = new Saw();
            //Builder builder = new Builder(hammer, saw);

            //Builder builder = new Builder();
            //builder.Hammer = new Hammer(); // Inject dependencies via Setters
            //builder.Saw = new Saw(); // Inject dependencies via Setters


            //Builder builder = new Builder();
            //builder.SetHammer(new Hammer());
            //builder.SetSaw(new Saw());
            //builder.BuildHouse();

            MultiInheritance multi = new MultiInheritance();
            multi.Process();
            Console.WriteLine("Hello, World!");
        }
    }
}
