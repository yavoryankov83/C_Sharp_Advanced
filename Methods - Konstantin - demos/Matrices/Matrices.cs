using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Matrices
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                {1, 2, 3, 4, 5 },
                {-10, 15, 23, 34, 1 },
                {1, 1, 1, 2, 2 }
            };

            PrintMatrix(matrix);

            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int[,] matrixFromConsole = ReadMatrix(r, c);
            PrintMatrix(matrixFromConsole);
        }

        private static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] result = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    result[row, col] = int.Parse(Console.ReadLine());
                }
            }
            return result;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write("{0, 4}", matrix[rows, cols]);
                }
                Console.WriteLine();
            }
        }
    }
}
