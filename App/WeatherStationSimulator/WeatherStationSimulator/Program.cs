namespace WeatherStationSimulator
{
    internal class Program
    {
        private static int[] _temperatures;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate:");
            int days = int.Parse(Console.ReadLine());
            string[] weatherConditions = new string[days];
            weatherConditions = GenerateWeatherConditions(days);
            Console.WriteLine($"Average Temp is : {CalculateTempAverage()}");
        }

        static string[] GenerateWeatherConditions(int days)
        {
            Random random = new Random();
            _temperatures = new int[days];
            string[] result = new string[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            for (int i = 0; i < days; i++) {
                _temperatures[i] = random.Next(-10, 40);
                result[i] = conditions[random.Next(conditions.Length)];
            }
            return result;
        }

        static decimal CalculateTempAverage() {
            decimal sum = 0;
            for (int i = 0; i < _temperatures.Length; i++)
            {
                sum += _temperatures[i];
            }
            return sum / _temperatures.Length;
        }
    }
}
