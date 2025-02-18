using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Program
    {

        public static void Rotate(int[][] matrix)
        {
            int n = matrix.Length;
            int[][] rotated = new int[n][];
            for (int i = 0; i < n; i++)
                rotated[i] = new int[n];

            // Copy elements to new positions
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    rotated[j][n - 1 - i] = matrix[i][j];
                }
            }

            // Copy back to the original matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i][j] = rotated[i][j];
                }
            }
        }

        static void PrintMatrix(int[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        static void Main()
        {
            int[][] matrix =
            {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9}
        };

            Console.WriteLine("Original Matrix:");
            PrintMatrix(matrix);

            Rotate(matrix);

            Console.WriteLine("\nRotated Matrix:");
            PrintMatrix(matrix);
        }
    }
}
