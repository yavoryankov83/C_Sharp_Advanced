using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            var matrix = new int[size[0]][];

            for (int rows = 0; rows < matrix.Length; rows++)
            {
                matrix[rows] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            var maxSum = int.MinValue;
            int maxRow = int.MinValue;
            int maxCol = int.MinValue;

            for (int rows = 0; rows < matrix.Length - 2; rows++)
            {
                for (int cols = 0; cols < matrix[rows].Length - 2; cols++)
                {
                    var currentMax = matrix[rows][cols] + matrix[rows][cols + 1] + matrix[rows][cols + 2]
                        + matrix[rows + 1][cols] + matrix[rows + 1][cols + 1] + matrix[rows + 1][cols + 2]
                        + matrix[rows + 2][cols] + matrix[rows + 2][cols + 1] + matrix[rows + 2][cols + 2];

                    if (currentMax > maxSum)
                    {
                        maxSum = currentMax;
                        maxRow = rows;
                        maxCol = cols;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine(matrix[maxRow][maxCol] + " " + matrix[maxRow][maxCol + 1] + " " + matrix[maxRow][maxCol + 2]);
            Console.WriteLine(matrix[maxRow + 1][maxCol] + " " + matrix[maxRow + 1][maxCol + 1] + " " + matrix[maxRow + 1][maxCol + 2]);
            Console.WriteLine(matrix[maxRow + 2][maxCol] + " " + matrix[maxRow + 2][maxCol + 1] + " " + matrix[maxRow + 2][maxCol + 2]);
        }
    }
}
