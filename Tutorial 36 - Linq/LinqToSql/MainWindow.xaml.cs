using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows;

namespace LinqToSql
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSqlDataClassesDataContext dataContext;
        public MainWindow()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager
                .ConnectionStrings["LinqToSql.Properties.Settings.universityConnectionString"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);
            try
            {
                //InsertUniversities();
                //InsertStudents();
                //InsertLectures();
                //InsertStudentLectureAssociations();
                //GetUniversityOfToni();
                //GetLectureOfToni();
                //GetAllStudentsFromYale();
                //GetAllUniveristiesWithFemale();
                //GetAllLectureInBeijingTech();
                //UpdateToni();
                DeleteJame();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertUniversities()
        {
            dataContext.ExecuteCommand("DELETE FROM University");
            University yale = new University();
            yale.Name = "Yale";
            dataContext.Universities.InsertOnSubmit(yale);
            University bjt = new University();
            bjt.Name = "Beijing Tech";
            dataContext.Universities.InsertOnSubmit(bjt);
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudents()
        {
            University yale = dataContext.Universities.First(un => un.Name.Equals("Yale"));
            University bjt = dataContext.Universities.First(un => un.Name.Equals("Beijing Tech"));

            List<Student> students = new List<Student>()
            {
                new Student(){ Name = "Carla", Gender = "Female", University = yale},
                new Student(){ Name = "Tonie Doe", Gender = "Male", University = yale},
                new Student(){ Name = "Leyla", Gender = "Female", University = bjt},
                new Student(){ Name = "Jame", Gender = "Male", University = bjt},
            };

            dataContext.Students.InsertAllOnSubmit(students);
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void InsertLectures()
        {
            dataContext.Lectures.InsertOnSubmit(new Lecture() { Name = "Math" });
            dataContext.Lectures.InsertOnSubmit(new Lecture() { Name = "History" });
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Lectures;
        }

        public void InsertStudentLectureAssociations()
        {
            Lecture Math = dataContext.Lectures.First(l => l.Name.Equals("Math"));
            Lecture History = dataContext.Lectures.First(l => l.Name.Equals("History"));

            Student carla = dataContext.Students.First(s => s.Name.Equals("Carla"));
            Student tonie = dataContext.Students.First(s => s.Name.Equals("Tonie Doe"));
            Student leyla = dataContext.Students.First(s => s.Name.Equals("Leyla"));
            Student jame = dataContext.Students.First(s => s.Name.Equals("Jame"));

            List<StudentLecture> studentLectures = new List<StudentLecture>()
            {
                new StudentLecture() { Student = carla, Lecture = Math},
                new StudentLecture() { Student = tonie, Lecture = Math},
                new StudentLecture() { Student = tonie, Lecture = History},
                new StudentLecture() { Student = leyla, Lecture = History}
            };

            dataContext.StudentLectures.InsertAllOnSubmit(studentLectures);
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.StudentLectures;
        }

        public void GetUniversityOfToni()
        {
            var tonie = dataContext.Students.First(st => st.Name.Equals("Tonie Doe"));
            var university = tonie.University;
            List<University> universities = new List<University>();
            universities.Add(university);
            MainDataGrid.ItemsSource = universities;
        }

        public void GetLectureOfToni()
        {
            var tonie = dataContext.Students.First(st => st.Name.Equals("Tonie Doe"));
            List<StudentLecture> studentLecture = dataContext.StudentLectures
                .Where(st => st.StudentId == tonie.Id).ToList();
            List<Lecture> lectures = (from lecture in dataContext.Lectures
                                     where studentLecture.Select(studentLec => studentLec.LectureId).Contains(lecture.Id)
                                     select lecture).ToList();
            MainDataGrid.ItemsSource = lectures;
        }

        public void GetAllStudentsFromYale()
        {
            var yale = from student in dataContext.Students
                       where student.University.Name.Equals("Yale")
                       select student;
            MainDataGrid.ItemsSource = yale;
        }

        public void GetAllUniveristiesWithFemale()
        {
            var universities = from student in dataContext.Students
                               join university in dataContext.Universities
                               on student.University equals university
                               where student.Gender == "Female"
                               select university;
            MainDataGrid.ItemsSource = universities.Distinct();
        }

        public void GetAllLectureInBeijingTech()
        {
            List<Lecture> lectures = (from studentLecture in dataContext.StudentLectures
                                      join lecture in dataContext.Lectures
                                      on studentLecture.LectureId equals lecture.Id
                                      where studentLecture.Student.University.Name.Equals("Beijing Tech")
                                      select lecture).ToList();
            MainDataGrid.ItemsSource = lectures;
        }
        
        public void UpdateToni()
        {
            var tonie = dataContext.Students.FirstOrDefault(st => st.Name.Equals("Tonie Doe"));
            tonie.Name = "Antonio";
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void DeleteJame()
        {
            Student jame = dataContext.Students.FirstOrDefault(st => st.Name.Equals("Jame"));
            if (jame != null) dataContext.Students.DeleteOnSubmit(jame);
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;
        }
    }
}
