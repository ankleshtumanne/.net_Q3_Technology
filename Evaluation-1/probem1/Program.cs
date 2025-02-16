using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probem1
{
    class Program
    {
        public  static int MaxSum(int[] num)
        {
            int maxSum = num[0];
            int currSum = num[0];

            for (int i = 1; i < num.Length; i++)
            {
                currSum = Math.Max(num[i], currSum + num[i]);
                maxSum = Math.Max(maxSum, currSum);
            }

            return maxSum;
        }
        static void Main(string[] args)
        {
            int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Console.WriteLine(MaxSum(arr));
        }
    }
}
