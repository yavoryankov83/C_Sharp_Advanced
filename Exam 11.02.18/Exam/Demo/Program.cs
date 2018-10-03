using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var matrix = new char[rows][];

            var samRow = 0;
            var samCol = 0;

            var nikRow = 0;
            var nikCol = 0;

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();
            }

            var inputCommands = Console.ReadLine().ToCharArray();




            for (int i = 0; i < inputCommands.Length; i++)
            {
                var currCommand = inputCommands[i];

                for (int row = 0; row < matrix.Length; row++)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        if (matrix[row][col] == 'S')
                        {
                            samRow = row;
                            samCol = col;
                        }
                        if (matrix[row][col] == 'N')
                        {
                            nikRow = row;
                            nikCol = col;
                        }
                        if (matrix[row][col] == 'b')
                        {
                            if (col == matrix[row].Length - 1)
                            {
                                matrix[row][col] = 'd';
                            }
                            else
                            {
                                if (matrix[row][col + 1] == 'S')
                                {
                                    Console.WriteLine($"Sam died at {row}, {col + 1}");
                                    matrix[row][col + 1] = 'X';
                                    printSolution(matrix);
                                }
                                else
                                {
                                    matrix[row][col + 1] = 'b';
                                    matrix[row][col] = '.';
                                }
                            }
                        }

                        if (matrix[row][col] == 'd')
                        {
                            if (col == 0)
                            {
                                matrix[row][col] = 'b';
                            }
                            else
                            {
                                if (matrix[row][col - 1] == 'S')
                                {
                                    Console.WriteLine($"Sam died at {row}, {col - 1}");
                                    matrix[row][col - 1] = 'X';
                                    printSolution(matrix);
                                }
                                else
                                {
                                    matrix[row][col - 1] = 'd';
                                    matrix[row][col] = '.';
                                }
                            }
                        }
                    }
                }

                switch (currCommand)
                {
                    case 'U':
                        if (samRow == nikRow)
                        {
                            matrix[nikRow][nikCol] = 'X';
                            Console.WriteLine("Nikoladze killed!");
                            printSolution(matrix);
                            return;
                        }
                        else
                        {
                            matrix[samRow - 1][samCol] = 'S';
                            matrix[samRow][samCol] = '.';
                        }
                        break;
                    case 'D':
                        if (samRow == nikRow)
                        {
                            matrix[nikRow][nikCol] = 'X';
                            Console.WriteLine("Nikoladze killed!");
                            printSolution(matrix);
                            return;
                        }
                        else
                        {
                            matrix[samRow + 1][samCol] = 'S';
                            matrix[samRow][samCol] = '.';
                        }
                        break;
                    case 'L':
                        if (samRow == nikRow)
                        {
                            matrix[nikRow][nikCol] = 'X';
                            Console.WriteLine("Nikoladze killed!");
                            printSolution(matrix);
                            return;
                        }
                        else
                        {
                            matrix[samRow][samCol - 1] = 'S';
                            matrix[samRow][samCol] = '.';
                        }
                        break;
                    case 'R':
                        if (samRow == nikRow)
                        {
                            matrix[nikRow][nikCol] = 'X';
                            Console.WriteLine("Nikoladze killed!");
                            printSolution(matrix);
                            return;
                        }
                        else
                        {
                            matrix[samRow][samCol + 1] = 'S';
                            matrix[samRow][samCol] = '.';
                        }
                        break;
                    case 'W':
                        continue;
                    default:
                        break;
                }

            }

            
        }







        private static void printSolution(char[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}
