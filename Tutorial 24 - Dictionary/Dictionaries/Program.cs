namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // key - value
            // declaring and initializing a Dictionary
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

            employees.Add(1, new Employee("John Does", 35, 100000));
            employees.Add(2, new Employee("John Doesnt", 25, 200000));
            employees.Add(3, new Employee("John Wasnt", 45, 80000));
            employees.Add(4, new Employee("John Will", 15, 50000));

            foreach (var employee in employees)
            {
                Console.WriteLine(
                    $" Id : {employee.Key}, name : {employee.Value.Name} " + 
                    $"earns {employee.Value.Salary}" + 
                    $" and is {employee.Value.Age} years old !");
            }

            Dictionary<string, string> codes = new Dictionary<string, string>()
            {
                ["NY"] = "New York",
                ["CA"] = "California",
                ["TX"] = "Texas"
            };

            if(codes.TryGetValue("NY", out string state))
            {
                Console.WriteLine(state);
            }

            foreach(var item in codes)
            {
                Console.WriteLine($"The state code is {item.Key} and the state name is {item.Value}");
            }
        }

        public class Employee
        {
            public Employee(string name, int age, int salary)
            {

                this.Name = name;
                this.Age = age;
                this.Salary = salary;
            }

            public string Name { get; set; }
            public int Age { get; set; }
            public int Salary { get; set; }
        }
    }
}
