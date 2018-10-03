using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Maximumsumof2x2submatrix
{
    class Maximumsumof2x2submatrix
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var rows = matrixSize[0];

            var matrix = new int[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            }

            var maxRow = 0;
            var maxCol = 0;
            var maxSum = int.MinValue;

            for (int row = 0; row < matrix.Length - 1; row++)
            {
                for (int col = 0; col < matrix[row].Length - 1; col++)
                {
                    var currentSum = matrix[row][col] + matrix[row][col + 1] + matrix[row + 1][col] + matrix[row + 1][col + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxRow][maxCol]} {matrix[maxRow][maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRow + 1][maxCol]} {matrix[maxRow + 1][maxCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
