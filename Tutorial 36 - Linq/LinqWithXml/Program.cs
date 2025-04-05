using System.Xml.Linq;

namespace LinqWithXml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentsXml =
                @"<Students>
                    <Student>
                        <Name>Tonic</Name>
                        <Age>21</Age>
                        <University>Yale</University>
                        <Hobby>Singing</Hobby>
                    </Student>
                    <Student>
                        <Name>Carla</Name>
                        <Age>17</Age>
                        <University>Yale</University>
                        <Hobby>Basketball</Hobby>
                    </Student>
                    <Student>
                        <Name>Leyla</Name>
                        <Age>19</Age>
                        <University>Beijing Tech</University>
                        <Hobby>Batminton</Hobby>
                    </Student>
                    <Student>
                        <Name>Lin</Name>
                        <Age>22</Age>
                        <University>Beijing Tech</University>
                        <Hobby>Drawing</Hobby>
                    </Student>
                </Students>";
            XDocument xdoc = XDocument.Parse(studentsXml);
            var students = from student in xdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = int.Parse(student.Element("Age").Value),
                               University = student.Element("University").Value,
                               Hobby = student.Element("Hobby").Value
                           };
            students = from student in students
                       orderby student.Age
                       select student;
            foreach (var student in students)
            {
                Console.WriteLine("Student's Name : {0}, Age : {1}, University : {2}, Hobby : {3}", 
                    student.Name, student.Age, student.University, student.Hobby);
            }
            Console.ReadLine();
        }
    }
}
