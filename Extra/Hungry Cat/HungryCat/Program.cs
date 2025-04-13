using System;

namespace HungryCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string characters = "F O~ O~ ~O O~";
            //NotHungryCats(characters);
            int pair = SumOfTwo.Find([1, 1, 1, 2, 3, 4, 5, 2], 2);
            Console.WriteLine(pair);
        }

        //public static int NotHungryCats(string kitchen)
        //{
        //    int followingCat = 0;
        //    int index = kitchen.IndexOf("F");
        //    for (int i = 0; i < kitchen.Length; i++)
        //    {
        //        char firstChars = kitchen[i];
        //        if (i < index)
        //        {
        //            if (kitchen[i].Equals('~')) continue;
        //            followingCat += CountLeftFacingCats(i, kitchen);
        //        }
        //        else
        //        {
        //            if (kitchen[i].Equals('O')) continue;
        //            followingCat += CountRightFacingCat(i, kitchen);
        //        }
        //    }
        //    Console.WriteLine(followingCat);
        //    return followingCat;
        //}

        //public static int CountLeftFacingCats(int i, string characters)
        //{
        //    string faceLeftCat = "O~";
        //    if (i == 0) return 0;
        //    char? prevChar = characters[i - 1];
        //    if (prevChar == null) return 0;
        //    string combineString = prevChar + "" + characters[i];
        //    if (combineString.Equals(faceLeftCat)) return 1;
        //    else return 0;
        //}

        //public static int CountRightFacingCat(int i, string characters)
        //{
        //    string faceRightCat = "~O";
        //    if (i + 1 == characters.Length) return 0;
        //    char? nextChar = characters[i + 1];
        //    if (nextChar == null) return 0;
        //    string combineString =  characters[i] + "" + nextChar;
        //    if (combineString.Equals(faceRightCat)) return 1;
        //    else return 0;
        //}
    }
}
