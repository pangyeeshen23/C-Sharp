﻿namespace InterfaceImp
{
    public interface IAnimal
    {
        void MakeSound();
        void Eat(string food);
    }

    public class Dog : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine("Dog ate " + food);
        }

        public void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine("Cat ate " + food);
        }

        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Dog dog = new Dog();
            //dog.MakeSound();
            //dog.Eat("Treat");

            //Cat cat = new Cat();
            //cat.MakeSound();
            //cat.Eat("Fish");
            IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
            PaymentPorcesser processor = new PaymentPorcesser(creditCardProcessor);
            processor.ProcessOrderPayment(1000);

            IPaymentProcessor paypalP= new PaypalProcessor();
            PaymentPorcesser paypalProcessor = new PaymentPorcesser(paypalP);
            paypalProcessor.ProcessOrderPayment(1000);
        }
    }
}
