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
            Console.WriteLine($"Max Temp was : {_temperatures.Max()}");
            Console.WriteLine($"Min Temp was : {GetMinTemperature()}");
            Console.WriteLine($"Min Temp was : {_temperatures.Min()}");
            Console.WriteLine($"Common Condition was :{FindMostCommonCondition(weatherConditions)}");
        }

        static string FindMostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommon = "";
            for (int i = 0; i < conditions.Length; i++)
            {
                int occurance = CountOccurance(conditions, conditions[i]);

                if (count < occurance)
                {
                    mostCommon = conditions[i];
                    count = occurance;
                }
            }
            return mostCommon;
        }

        static int CountOccurance(string[] conditions, string currentCondition)
        {
            int tempCount = 0;
            for (int j = 0; j < conditions.Length; j++)
            {
                if (currentCondition == conditions[j]) tempCount++;
            }
            return tempCount;
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

        static int GetMinTemperature()
        {
            int min = _temperatures[0];
            foreach (int temp in _temperatures) 
            {
                if (temp < min) min = temp;
            }
            return min;
        }
    }
}
