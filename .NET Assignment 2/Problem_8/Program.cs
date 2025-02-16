using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8
{
    class Program
    {
        public static int KthSmallestElement(int[] arr, int k)
        {
            return QuickSelect(arr, 0, arr.Length - 1, k - 1);
        }

        private static int QuickSelect(int[] arr, int left, int right, int k)
        {
            if (left == right) return arr[left];

            int pivotIndex = Partition(arr, left, right);

            if (k == pivotIndex)
                return arr[k];
            else if (k < pivotIndex)
                return QuickSelect(arr, left, pivotIndex - 1, k);
            else
                return QuickSelect(arr, pivotIndex + 1, right, k);
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left;

            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    Swap(arr, i, j);
                    i++;
                }
            }
            Swap(arr, i, right);
            return i;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static void Main(string[] args)
        {
            int[] arr = { 7, 10, 4, 3, 20, 15 };
            int k = 3;
            Console.WriteLine(KthSmallestElement(arr, k));
        }
    }
}
