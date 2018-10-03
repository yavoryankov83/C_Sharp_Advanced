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
            var input = Console.ReadLine().Split();

            var rows = int.Parse(input[0]);
            var cols = int.Parse(input[1]);

            var matrix = new int[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions
                    .RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            var maxSum = int.MinValue;
            var maxRow = 0;
            var maxCol = 0;

            for (int row = 0; row < matrix.Length - 2; row++)
            {
                for (int col = 0; col < matrix.Length - 2; col++)
                {
                    var firstRow = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2];
                    var secondRow = matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2];
                    var thirdRow = matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];

                    var sum = firstRow + secondRow + thirdRow;

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");

            Console.WriteLine($"{matrix[maxRow][maxCol]} {matrix[maxRow][maxCol + 1]} {matrix[maxRow][maxCol + 2]}");
            Console.WriteLine($"{matrix[maxRow + 1][maxCol]} {matrix[maxRow + 1][maxCol + 1]} {matrix[maxRow + 1][maxCol + 2]}");
            Console.WriteLine($"{matrix[maxRow + 2][maxCol]} {matrix[maxRow + 2][maxCol + 1]} {matrix[maxRow + 2][maxCol + 2]}");
        }
    }
}
