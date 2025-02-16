using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9
{
    class Program
    {
        public static int MaxProductOfThree(int[] arr)
        {
            Array.Sort(arr);
            int n = arr.Length;

           
            int option1 = arr[n - 1] * arr[n - 2] * arr[n - 3];

           
            int option2 = arr[0] * arr[1] * arr[n - 1];

            return Math.Max(option1, option2);
        }

        public static void Main()
        {
            int[] arr = { 1, 10, -5, 1, -100 };
            Console.WriteLine(MaxProductOfThree(arr)); 
        }
    }
}
