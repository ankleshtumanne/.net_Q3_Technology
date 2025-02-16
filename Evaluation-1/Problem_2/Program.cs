using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        
        static int[] Union(int[] arr1, int[] arr2)
        {
            int n1 = arr1.Length, n2 = arr2.Length;
            int[] result = new int[n1 + n2];
            int i = 0, j = 0, index = 0;

            while (i < n1 && j < n2)
            {
                if (arr1[i] < arr2[j])
                    result[index++] = arr1[i++];
                else if (arr1[i] > arr2[j])
                    result[index++] = arr2[j++];
                else
                {
                    result[index++] = arr1[i++];
                    j++; 
                }
            }

            while (i < n1) result[index++] = arr1[i++];
            while (j < n2) result[index++] = arr2[j++];

            return TrimArray(result, index);
        }

        
        static int[] Intersection(int[] arr1, int[] arr2)
        {
            int n1 = arr1.Length, n2 = arr2.Length;
            int[] result = new int[Math.Min(n1, n2)];
            int i = 0, j = 0, index = 0;

            while (i < n1 && j < n2)
            {
                if (arr1[i] < arr2[j])
                    i++;
                else if (arr1[i] > arr2[j])
                    j++;
                else
                {
                    result[index++] = arr1[i];
                    i++;
                    j++;
                }
            }

            return TrimArray(result, index);
        }

        
        static int[] TrimArray(int[] arr, int size)
        {
            int[] result = new int[size];
            for (int i = 0; i < size; i++)
                result[i] = arr[i];
            return result;
        }

        static void Main()
        {
            int[] arr1 = { 3, 1, 7, 5, 4 };
            int[] arr2 = { 6, 2, 5, 3 };

            
            BubbleSort(arr1);
            BubbleSort(arr2);

            int[] unionResult = Union(arr1, arr2);
            int[] intersectionResult = Intersection(arr1, arr2);

            Console.WriteLine("Union: " + string.Join(", ", unionResult));
            Console.WriteLine("Intersection: " + string.Join(", ", intersectionResult));
        }
    }
}
