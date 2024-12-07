using System;

namespace Coding.Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person("Ali", 24);
            person.Greet();
        }
    }

    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        private string _name;
        private int _age;

        public string Name { get { return _name; } set { _name = value; } }
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value > 0) _age = value;
            }
        }

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {_name} and I am {_age} years old.");
        }


    }
}
