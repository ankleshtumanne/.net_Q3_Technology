using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_3
{
    class Program
    {
        static int FirstMissingPositive(int[] num)
        {
            int n = num.Length;

            
            for (int i = 0; i < n; i++)
            {
                while (num[i] > 0 && num[i] <= n && num[num[i] - 1] != num[i])
                {
                   
                    int temp = num[i];
                    num[i] = num[temp - 1];
                    num[temp - 1] = temp;
                }
            }

            
            for (int i = 0; i < n; i++)
            {
                if (num[i] != i + 1)
                    return i + 1;
            }

            
            return n + 1;
        }

        static void Main()
        {
            int[] arr = { 3, 4, -1, 1 };

            int missNumber = FirstMissingPositive(arr);
            Console.WriteLine(missNumber);
        }
    }
}
