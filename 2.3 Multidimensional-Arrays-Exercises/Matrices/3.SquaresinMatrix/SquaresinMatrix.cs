using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SquaresinMatrix
{
    class SquaresinMatrix
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine()
                .Split();

            var row = int.Parse(size[0]);
            var col = int.Parse(size[1]);

            var matrix = new char[row][];

            for (int rows = 0; rows < matrix.Length; rows++)
            {

                matrix[rows] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

            }

            var count = 0;

            for (int rows = 0; rows < matrix.Length - 1; rows++)
            {
                for (int cols = 0; cols < matrix[rows].Length - 1; cols++)
                {
                    if (matrix[rows][cols] == matrix[rows][cols + 1]
                        && matrix[rows][cols] == matrix[rows + 1][cols]
                        && matrix[rows][cols] == matrix[rows + 1][cols + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
