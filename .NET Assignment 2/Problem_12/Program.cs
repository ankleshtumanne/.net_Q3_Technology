using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12
{
    class Program
    {
        public static int FindPeakElement(int[] arr)
        {
            int n = arr.Length;

           
            if (n == 1 || arr[0] > arr[1]) return arr[0];
            if (arr[n - 1] > arr[n - 2]) return arr[n - 1];

            
            for (int i = 1; i < n - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                    return arr[i];
            }

            return -1; 
        }

        public static void Main()
        {
            int[] arr = { 1, 2, 3, 1 };
            Console.WriteLine(FindPeakElement(arr)); 
        }
    }
}
