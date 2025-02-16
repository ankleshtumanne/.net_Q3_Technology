using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3.net
{
    class Program
    {
        public static int FindMissNumber(int[] arr, int n)
        {
            int expectedSum = (n * (n + 1)) / 2;
            int Sum = 0;
            //string s = "";
            for(int i=0;i<arr.Length;i++)
            {
                Sum += arr[i];
            }
            return expectedSum-Sum
        }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 4, 5, 6 };
            int n = 3;
            Console.WriteLine("Missing number: " + FindMissNumber(numbers, n));
            Console.ReadLine();
        }
    }
}
