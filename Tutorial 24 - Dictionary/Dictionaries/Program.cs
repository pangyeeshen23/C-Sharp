namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // key - value
            // declaring and initializing a Dictionary
            Dictionary<int, string> employees = new Dictionary<int, string>();

            // Adding Items to a Dictionary
            employees.Add(101, "John Doe");
            employees.Add(102, "Bob Smith");
            employees.Add(103, "Rob Smith");
            employees.Add(104, "Flob Smith");
            employees.Add(105, "Dob Smith");

            string name = employees[101];
            Console.WriteLine(name);

            // access item in a dictionary
            employees[102] = "Jane Smith";

            // remove an item form a dictionary
            employees.Remove(101);

            foreach(KeyValuePair<int, string> employee in employees)
            {
                Console.WriteLine($"Id: {employee.Key}, Name: {employee.Value}");
            }

        }
    }
}
