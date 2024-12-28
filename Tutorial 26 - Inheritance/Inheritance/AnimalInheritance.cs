using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class AnimalInheritance
    {
        public void Run()
        {
            Dog myDog = new Dog();
            myDog.Eat();
            myDog.MakeSound();
            Collie collie = new Collie();
            collie.GoingNuts();

            Cat myCat = new Cat();
            myCat.MakeSound();

        }

        // Base Class (Parent Class or Superclass)
        class Animal
        {
            public void Eat()
            {

                Console.WriteLine("Eating ...");
            }

            public virtual void MakeSound()
            {
                Console.WriteLine("Animal makes a generic sound");
            }
        }

        //Derived Class (Child Class or Subclass):
        // the class that inherits the members of the base class
        class Dog : Animal
        {
            public override void MakeSound()
            {
                base.MakeSound();
                Console.WriteLine("Barking ...");
            }
        }


        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Cat is meowing");
            }
        }

        // a breed of dog
        // This is multi-level inheritance
        class Collie : Dog
        {
            public void GoingNuts()
            {
                Console.WriteLine("Collie going nuts");
            }
        }
    }
}
