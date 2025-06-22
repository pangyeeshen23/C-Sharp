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

            Animal dog = new Dog();
            dog.MakeSound();
            Console.WriteLine(myDog);

            Animal dog2 = new Dog();
            dog2.Sit();

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

            public void Sit()
            {
                Console.WriteLine("Animal Sit");
            }
        }

        //Derived Class (Child Class or Subclass):
        // the class that inherits the members of the base class
        class Dog : Animal
        {
            public override sealed void MakeSound()
            {
                base.MakeSound();
                Console.WriteLine("Barking ...");
            }

            public new void Sit()
            {
                Console.WriteLine("Dog Sit");
            }
        }


        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Cat is meowing");
            }

            public new void Sit()
            {
                Console.WriteLine("Cat Sit");
            }
        }

        // a breed of dog
        // This is multi-level inheritance
        class Collie : Dog
        {
            // this will result in compiler error because MakeSound is sealed in Dog class
            //public override void MakeSound()
            //{

            //}

            public void GoingNuts()
            {
                Console.WriteLine("Collie going nuts");
            }
        }
    }
}
