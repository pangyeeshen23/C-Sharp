namespace DateTimeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            DateTime dt = new DateTime(1988, 5 , 23);
            DateTime dt2 = new DateTime();
            
            Console.WriteLine("My birthday is {0}!", dt);

            // Write today on screen
            Console.WriteLine(DateTime.Today);

            // Write current time on screen
            Console.WriteLine(DateTime.Now);
            
            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("Tomorrow will be the {0}", tomorrow);
            Console.WriteLine("Todat is {0}", DateTime.Today.DayOfWeek);
            Console.WriteLine(GetFirstDayOfYear(1999));

            int days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("Days in Feb 2000 : {0}", days);
            days = DateTime.DaysInMonth(2001, 2);
            Console.WriteLine("Days in Feb 2000 : {0}", days);
            days = DateTime.DaysInMonth(2004, 2);
            Console.WriteLine("Days in Feb 2000 : {0}", days);

            DateTime now = DateTime.Now;
            Console.WriteLine("Minute: {0}", now.Minute);
            Console.WriteLine("Hour: {0}", now.Hour);

            // Display the time in this structure 
            Console.WriteLine("{0} o'clock {1} minutes and {2} seconds", now.Hour, now.Minute, now.Second);

            Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out DateTime dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("Days passed since : {0}", daysPassed.Days);
            }
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
