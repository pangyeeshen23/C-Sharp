using System.Collections;

namespace LegacyList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList(); // undefined amount of object
            ArrayList arrayList2 = new ArrayList(100); // defined amount of object

            arrayList.Add(12);
            arrayList.Add("Name");
            arrayList.Add(13.37);
            arrayList.Add(128);
            arrayList.Add('C');
            arrayList.Add("Name");

            // delete element with specific entry from the array list
            arrayList.Remove("Name");

            // delete element at specific position
            arrayList.RemoveAt(0);

            int count = arrayList.Count;

            Console.WriteLine(count);
            double sum = 0;
            foreach (object obj in arrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double) obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine(sum);
        }
    }
}
