using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10
{
    class Program
    {
        public static bool CanJump(int[] nums)
        {
            int farthest = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > farthest) return false; 

                farthest = Math.Max(farthest, i + nums[i]);

                if (farthest >= nums.Length - 1) return true;
            }

            return false;
        }
        static void Main(string[] args)
        {
            int[] nums1 = { 2, 3, 1, 1, 4 };
            

            Console.WriteLine(CanJump(nums1)); 
            
        
    }
    }
}
