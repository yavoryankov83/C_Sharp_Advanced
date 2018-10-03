using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            var matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currRow = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions
                    .RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            var primarySum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                primarySum += matrix[row, row];
            }

            var secondarySum = 0;

            var cols = size - 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                secondarySum += matrix[row, cols];
                cols--;
            }

            Console.WriteLine(Math.Abs(primarySum - secondarySum));
        }
    }
}
