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

            var matrix = new int[size][];
            var primarySum = 0;
            var secondarySum = 0;

            for (int rows = 0; rows < matrix.Length; rows++)
            {
                matrix[rows] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            for (int rows = 0; rows < matrix.Length; rows++)
            {
                for (int cols = rows; cols < rows + 1; cols++)
                {
                    primarySum += matrix[rows][cols];
                }
            }

            for (int rows = 0, cols = matrix[rows].Length - 1; rows < matrix.Length; rows++, cols--)
            {
                secondarySum += matrix[rows][cols];
            }

            var difference = Math.Abs(primarySum - secondarySum);

            Console.WriteLine(difference);
        }
    }
}
