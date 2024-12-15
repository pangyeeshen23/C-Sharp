namespace NullableList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? age = null; // int? is a nullable int
            int myAge = 35;

            if (age.HasValue)
            {
                int sum = age.Value + myAge;
                Console.WriteLine("Age is:" + age.Value);
            }
            else
            {
                Console.WriteLine("Age is not specified");
            }
        }
    }
}
