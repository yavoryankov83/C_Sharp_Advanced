using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SumMatrixElements
{
    class SumMatrixElements
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var matrix = new int[size[0]][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            }
            var sum = 0;

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    sum += matrix[row][col];
                }
            }
            Console.WriteLine(size[0]);
            Console.WriteLine(size[1]);
            Console.WriteLine(sum);
        }
    }
}
