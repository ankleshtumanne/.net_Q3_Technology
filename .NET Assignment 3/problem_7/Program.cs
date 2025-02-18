using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_7
{
    class Program
    {
        public static int FindMissingNumber(int[] nums)
        {
            int n = nums.Length + 1; // Since one number is missing, the total should be n+1
            int expectedSum = (n * (n + 1)) / 2;
            int actualSum = 0;

            foreach (int num in nums)
            {
                actualSum += num;
            }

            return expectedSum - actualSum;
        }

        static void Main()
        {
            int[] nums = { 3, 7, 1, 2, 8, 4, 5 }; // Missing number is 6

            Console.WriteLine("Missing Number: " + FindMissingNumber(nums));
        }
    }
}
