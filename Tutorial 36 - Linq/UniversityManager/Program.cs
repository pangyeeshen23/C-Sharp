namespace UniversityManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            //um.MaleStudents();
            //um.FemaleStudents();
            //um.SortStudentByAge();
            //um.AllStudentsFromBeijingTech();
            um.StudentAndUniversityNameCollection();
            //string input = Console.ReadLine();
            //try
            //{
            //    int inputAsInt = Convert.ToInt32(input);
            //    um.AllStudentsFromThatUni(inputAsInt);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Please enter a valid number");
            //}
            //int[] someInts = { 30, 12, 4, 3, 12 };
            //IEnumerable<int> sortedInt = from i in someInts orderby i select i;
            //IEnumerable<int> reversedInts = sortedInt.Reverse();
            //foreach(int i in reversedInts)
            //{
            //    Console.WriteLine(i);
            //}
            //IEnumerable<int> reversedSortedInts = from i in someInts orderby i descending select i;
            //foreach(int i in reversedSortedInts)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Hello, World!");
        }
    }
}
