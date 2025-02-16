using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11
{
    class Program
    {
        public static int[] TwoSumSorted(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;

            while (left < right)
            {
                int sum = arr[left] + arr[right];

                if (sum == target)
                    return new int[] { left , right  }; 

                if (sum < target)
                    left++;  
                else
                    right--; 
            }

            return new int[] { -1, -1 }; 
        }
        public static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 6 };
            int target = 6;

            int[] result = TwoSumSorted(arr, target);
            Console.WriteLine($"[{result[0]}, {result[1]}]"); 
        }
    }
}
