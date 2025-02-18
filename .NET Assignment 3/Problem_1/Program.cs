using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        public static int MaxArea(int[] height)
        {
            int left = 0, right = height.Length - 1;
            int maxArea = 0;

            while (left < right)
            {
                
                int minHeight = Math.Min(height[left], height[right]);
                int width = right - left;
                int area = minHeight * width;

                
                maxArea = Math.Max(maxArea, area);

                
                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }

            return maxArea;
        }
        static void Main(string[] args)
        {
           
            
                int[] heights = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
                int maxWater = MaxArea(heights);
                Console.WriteLine(maxWater);
            
        }
    }
}
