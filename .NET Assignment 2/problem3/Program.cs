using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem3
{
    class Program
    {
        public static string ReverseArray(int[] arr)
        {
            string s = "";
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                s += arr[i] + " ";
            }
            return s.Trim();
        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };
            Console.WriteLine(ReverseArray(numbers));
        }
    }
    //class Program
    //{
    //    public static string ReverseArray(int[] arr)
    //    {
    //        return string.Join(" ", arr.Reverse()); // Uses LINQ to reverse the array
    //    }

    //    static void Main(string[] args)
    //    {
    //        int[] numbers = { 1, 2, 3, 4 };
    //        Console.WriteLine(ReverseArray(numbers));
    //    }
    //}
}
