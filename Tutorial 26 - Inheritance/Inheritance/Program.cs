namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Eat();
            myDog.Bark();
            Console.WriteLine("Hello, World!");
        }
    }


    // Base Class (Parent Class or Superclass)
    class Animal
    {
        public void Eat()
        { 
        
            Console.WriteLine("Eating ...");
        }
    }

    //Derived Class (Child Class or Subclass):
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking ...");
        }
    }
}
