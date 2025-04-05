using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManager
{
    class UniversityManager
    {
        public List<University> _universities;
        public List<Student> _students;

        public UniversityManager()
        {
            _universities = new List<University>();
            _students = new List<Student>();

            _universities.Add(new University { Id = 1, Name = "Yale" });
            _universities.Add(new University { Id = 2, Name = "Beijing Tech" });

            _students.Add(new Student { Id = 1, Name = "Carla", Gender = "male", Age = 17, UniversityId = 1 });
            _students.Add(new Student { Id = 2, Name = "Toni", Gender = "female", Age = 21, UniversityId = 1 });
            _students.Add(new Student { Id = 3, Name = "Frank", Gender = "male", Age = 22, UniversityId = 2 });
            _students.Add(new Student { Id = 4, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2 });
            _students.Add(new Student { Id = 5, Name = "James", Gender = "transgender", Age = 25, UniversityId = 2 });
            _students.Add(new Student { Id = 6, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in _students where student.Gender == "male" select student;
            Console.WriteLine("Male - Students : ");
            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudens = from student in _students where student.Gender == "female" select student;
            Console.WriteLine("Female - Students : ");
            foreach (Student student in femaleStudens)
            {
                student.Print();
            }
        }

        public void SortStudentByAge()
        {
            IEnumerable<Student> sortedStudents = from student in _students orderby student.Age select student;
            Console.WriteLine("Student sorted by Age:");
            foreach (Student student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromBeijingTech()
        {
            IEnumerable<Student> bjtStudent = from student in _students 
                                                  join university in _universities on student.UniversityId equals university.Id
                                                  where university.Name == "Beijing Tech"
                                                  select student;
            Console.WriteLine("All Beijing Tech Student :");
            foreach(Student student in bjtStudent)
            {
                student.Print();
            }
        }

        public void AllStudentsFromThatUni(int Id)
        {
            IEnumerable<Student> myStudents = from student in _students
                                              join university in _universities on student.UniversityId equals university.Id
                                              where university.Id == Id
                                              select student;
            Console.WriteLine("All Students from that University {0} :", Id);
            foreach (Student student in myStudents)
            {
                student.Print();
            }
        }
    }
}
