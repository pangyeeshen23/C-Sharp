int[] myIntArray = [5, 15, 20, 45, 55];
string[] weekDays = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];

Console.WriteLine("Length of weekdays Array is: " + weekDays.Length);

//for(int i = 0; i < weekDays.Length; i++)
//{
//    Console.WriteLine(weekDays[i]);
//}

foreach (string day in weekDays)
{
    Console.WriteLine(day);
}