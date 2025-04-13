using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryCat
{
    class SumOfTwo
    {
        public static int Find(int[] nums, int sumToFind)
        {
            int pair = 0;
            for(int i = 1; i < nums.Length; i++)
            {
                int prevNum = nums[i - 1];
                int sum = nums[i] + prevNum;
                if (sum == sumToFind) pair++;
            }
            return pair;
        }
    }
}
