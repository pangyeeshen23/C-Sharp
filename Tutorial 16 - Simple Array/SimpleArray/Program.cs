int[] myIntArray = [5, 15, 20, 45, 55];
string[] weekDays = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];

Console.WriteLine("Length of weekdays Array is: " + weekDays.Length);


foreach (string day in weekDays)
{
    Console.WriteLine(day);
}

int[,] array2DDeclaration = new int[3, 3];

int[,,] array3DDeclaration = new int[3, 3, 3];

int[,] array2DInitialized = { { 1, 2 }, { 3, 4 } };
// [1] [2] // row 0
// [3] [4] // row 1

Console.WriteLine(array2DInitialized[0, 0]);

array2DInitialized[0, 0] = 5;

Console.WriteLine(array2DInitialized[0, 0]);

Console.WriteLine(array2DInitialized[1, 0]);

string[,] tikTacToeField = {
    {"O","X","O" },
    {"O","O","X" },
    {"X","X","O" }
};

Console.WriteLine(tikTacToeField[1, 2]);

string[,,] simple3DArray =
{
    {
        {"000","001"},
        {"010", "011"}
    },
    {
        {"100", "101"},
        {"110", "111"}
    },
    {
        {"200", "201" },
        {"210", "211" }
    }
};

Console.WriteLine(simple3DArray);

simple3DArray[2, 1, 0] = "Hi, whats up";

Console.WriteLine(simple3DArray[0,1,0]);

//for(int i = 0; i < weekDays.Length; i++)
//{
//    Console.WriteLine(weekDays[i]);
//}