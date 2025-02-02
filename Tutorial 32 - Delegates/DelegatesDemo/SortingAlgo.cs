using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    internal class SortingAlgo
    {
        public delegate int Comparison<T> (T x, T y);

        public void Process()
        {
            Person[] people =
            {
                new Person{ Name = "Alice", Age = 30 },
                new Person{ Name = "Bob", Age = 25 },
                new Person{ Name = "Denis", Age = 36 },
                new Person{ Name = "Charlie", Age = 35 },
                new Person{ Name = "Jamie", Age = 25 }
            };

            PersonSorter sorter = new PersonSorter();
            sorter.Sort(people, CompareByAge);
            foreach (Person person in people)
            {
                Console.WriteLine("Person Name :" + person.Name + " Age : " + person.Age);
            }

            sorter.Sort(people, CompareByName);
            foreach (Person person in people)
            {
                Console.WriteLine("Person Name :" + person.Name + " Age : " + person.Age);
            }
        }

        static int CompareByAge(Person person1, Person person2)
        {
            return person1.Age.CompareTo(person2.Age);
        }

        static int CompareByName(Person person1, Person person2)
        {
            return person1.Name.CompareTo(person2.Name);
        }

        public static void PrintArray<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class PersonSorter
    {
        public void Sort(Person[] people, Comparison<Person> comparison)
        {
            for(int i = 0; i < people.Length - 1; i++)
            {
                bool isSwapped = false;
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (comparison(people[i], people[j]) > 0)
                    {
                        Person temp = people[i];
                        people[i] = people[j]; 
                        people[j] = temp;
                        isSwapped = true;
                    }
                }
                if (isSwapped == false) break;
            }
        }
    }
}
