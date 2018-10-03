using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MatrixofPalindromes
{
    class MatrixofPalindromes
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var row = input[0];
            var col = input[1];

            var matrix = new string[row][];

            var firstLetter = 'a';

            for (char rows = 'a'; rows < firstLetter + row; rows++)
            {
                for (char cols = rows; cols < rows + col; cols++)
                {
                    var expression = rows.ToString() + cols.ToString() + rows.ToString() + " ";
                    Console.Write(expression);
                }
                Console.WriteLine();
            }
        }
    }
}
