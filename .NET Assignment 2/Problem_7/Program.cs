using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7
{
    class Program
    {
        public static int LongestConsecutive(int[] arr)
        {
            int maxLength = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                int count = 1;
                while (Array.Exists(arr, element => element == num + 1))
                {
                    num++;
                    count++;
                }

                maxLength = Math.Max(maxLength, count);
            }
            return maxLength;
        }
        static void Main(string[] args)
        {
            int[] arr = { 100, 4, 200, 1, 3, 2 };
            Console.WriteLine(LongestConsecutive(arr));
        }
    }
}
