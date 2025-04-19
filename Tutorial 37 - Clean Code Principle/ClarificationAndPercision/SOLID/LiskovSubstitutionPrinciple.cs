namespace ClarificationAndPercision.SOLID
{
    class LiskovSubstitutionPrinciple
    {
        public static void Main()
        {
            Sparrow sparrow = new Sparrow();
            sparrow.MakeSound();
            ((IFlyable)sparrow).Fly();

            Penguin penguin = new Penguin();
            penguin.MakeSound();
        }
    }

    public class Bird
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Bird is chirping");
        }
    }

    // Liskov Substitution Principle:
    // Rather than having the IFlyable method into the Bird class. It would be better to have an interface to introduce
    // that method into the Sparrow class.
    // this is becaus Penguin cannot fly and it would not be appropriate to have a Fly method in the Bird class.
    // so we introduce the inteface as an contract.


    public class Sparrow : Bird, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Sparrow is flying");
        }
    }

    public class Penguin : Bird
    {

    }

    public interface IFlyable
    {
        void Fly();
    }

}
