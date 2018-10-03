using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    class PascalTriangle
    {
        static void Main(string[] args)
        {
            int heigth = 10;

            int[][] pascalTriangle = new int[heigth][];
            pascalTriangle[0] = new int[1];
            pascalTriangle[0][0] = 1;

            for (int row = 1; row < heigth; row++)
            {
                pascalTriangle[row] = new int[row + 1];
                pascalTriangle[row][0] = 1;

                for (int col = 1; col < row; col++)
                {
                    pascalTriangle[row][col] = pascalTriangle[row - 1][col - 1] + pascalTriangle[row - 1][col];
                }

                pascalTriangle[row][row] = 1;
            }
            for (int row = 0; row < pascalTriangle.Length; row++)
            {
                for (int col = 0; col < pascalTriangle[row].Length; col++)
                {
                    Console.Write("{0} ", pascalTriangle[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}
