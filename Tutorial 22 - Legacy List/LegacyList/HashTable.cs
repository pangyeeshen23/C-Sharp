using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyList
{
    internal static class HashTables
    {

        public static void Demo()
        {
            Hashtable studentsTable = new Hashtable();
            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);
            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            Student storedStudent1 = (Student) studentsTable[1];
            Student storedStudent2 = (Student) studentsTable[2];

            // retrieve all value from a Hashtable
            foreach (DictionaryEntry student in studentsTable)
            {
                Student temp = (Student) student.Value;
                Console.WriteLine("Student Id:{0}", temp.Id);
                Console.WriteLine("Student Name:{0}", temp.Name);
                Console.WriteLine("Student GPA:{0}", temp.GPA);
            }

            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("Student Id:{0}", value.Id);
                Console.WriteLine("Student Name:{0}", value.Name);
                Console.WriteLine("Student GPA:{0}", value.GPA);
            }
        }
    }

    class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
