using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9
{
    class Program
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return left; // The insertion index
        }

        static void Main()
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 5;

            Console.WriteLine(SearchInsert(nums, target));
        }
    }
}
