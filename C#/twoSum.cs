using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoSum
{
    class myTwoSum
    {
        static void Main(string[] args)
        {
            int target = 6;
            int[] nums = new int[] { 3, 3 };
            int[] output = TwoSum(nums, target);
            Console.WriteLine("[{0}, {1}]",output[0],output[1]);
            Console.ReadKey();
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int temp, myIndex;
            int[] output = new int[2];
            Dictionary<int, int> myNums = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                myNums.Add(i,nums[i]);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                temp = target - nums[i];
                if (nums.Contains(temp)) {
                    myIndex = myNums.FirstOrDefault(x => x.Value == temp).Key;
                    output[0] = i;
                    output[1] = myIndex;
                }
            }
            return output;
         

        }
    }
}
