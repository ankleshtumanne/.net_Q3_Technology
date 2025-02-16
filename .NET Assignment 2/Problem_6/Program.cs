using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6
{
    class Program
    {
        public static void RotateArray(int[] arr, int k)
        {
            int n = arr.Length;
            k = k % n; // Ensure k is within bounds

            Reverse(arr, 0, n - 1);  // Step 1: Reverse entire array
            Reverse(arr, 0, k - 1);  // Step 2: Reverse first k elements
            Reverse(arr, k, n - 1);  // Step 3: Reverse remaining elements
        }
        public static void Reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = {1, 2, 3, 4, 5, 6, 7};
            int k = 3;
            
            RotateArray(arr, k);
            Console.WriteLine("Rotated Array: " + string.Join(", ", arr));
        }
    }
}
