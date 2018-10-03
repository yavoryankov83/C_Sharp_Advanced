using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplication
{
    class MatrixMultiplication
    {
        static void Main(string[] args)
        {
            int[,] first =
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            int[,] second =
            {
                { 7, 8 },
                { 9, 10 },
                {11, 12 }
            };

            var rows = first.GetLength(0);
            var cols = second.GetLength(1);

            int[,] result = new int[rows, cols];

            for (int row = 0; row < result.GetLength(0); row++)
            {
                for (int col = 0; col < result.GetLength(1); col++)
                {
                    int currentResult = 0;

                    for (int element = 0; element < first.GetLength(0); element++)
                    {
                        currentResult += first[row, element] * second[element, col];
                    }

                    result[row, col] = currentResult;
                }
            }
        }
    }
}
