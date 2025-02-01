namespace EnumDemo
{
    public enum Day { Mo, Tu, We, Th, Fr, Sa, Su };
    public enum Month { Jan = 1, Feb, Mar, Apr, May, Jun, Jul = 12, Aug, Sept, Oct, Nov, Dec };

    internal class Program
    {
        static void Main(string[] args)
        {
            Day fr = Day.Fr;
            Day su = Day.Su;
            Day a = Day.Fr;

            Console.WriteLine(fr == a);
            Console.WriteLine(Day.Mo);
            Console.WriteLine((int)Day.Mo);

            Console.WriteLine(Month.Feb);
            Console.WriteLine((int) Month.Aug);
        }
    }
}
