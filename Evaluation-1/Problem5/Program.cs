using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void RotateMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);

            
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++) 
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)  
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, n - j - 1];
                    matrix[i, n - j - 1] = temp;
                }
            }
        }


        static void PrintMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
            static void Main(string[] args)
        {
            int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

           

            RotateMatrix(matrix);

            Console.WriteLine("\nRotated Matrix (90' Clockwise):");
            PrintMatrix(matrix);
        }
    }
}
