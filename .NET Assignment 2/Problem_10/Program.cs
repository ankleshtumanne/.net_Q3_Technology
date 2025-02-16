using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10
{
    class Program
    {
        public static int[] MergeSortedArrays(int[] arr1, int[] arr2)
        {
            
            int[] mergedArray = arr1.Concat(arr2).ToArray();

            
            Array.Sort(mergedArray);

            return mergedArray;
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 3, 5 };
            int[] arr2 = { 2, 4, 6 };

            int[] result = MergeSortedArrays(arr1, arr2);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
