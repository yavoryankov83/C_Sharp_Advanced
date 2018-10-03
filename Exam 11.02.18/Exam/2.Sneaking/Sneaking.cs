using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sneaking
{
    class Sneaking
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

            var inputCommands = Console.ReadLine().ToUpper().ToCharArray();

            foreach (var command in inputCommands)
            {
                for (int row = 0; row < matrix.Length; row++)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        if (matrix[row][col] == 'S')
                        {
                            samRow = row;
                            samCol = col;
                            break;
                        }
                        else if (matrix[row][col] == 'N')
                        {
                            nikRow = row;
                            nikCol = col;
                            break;
                        }
                        else if (matrix[row][col] == 'b')
                        {
                            if (col == matrix.Length - 1)
                            {
                                matrix[row][col] = 'd';
                                break;
                            }
                            else
                            {
                                if (matrix[row][col + 1] == 'S')
                                {
                                    matrix[row][col] = '.';
                                    Console.WriteLine($"Sam died at {samRow}, {samCol}");
                                    matrix[samRow][samCol] = 'X';
                                    PrintMatrix(matrix);
                                    return;
                                }
                                else
                                {
                                    matrix[row][col + 1] = 'b';
                                    matrix[row][col] = '.';
                                    break;
                                }
                            }
                        }
                        else if (matrix[row][col] == 'd')
                        {
                            if (col == 0)
                            {
                                matrix[row][col] = 'b';
                                break;
                            }
                            else
                            {
                                if (matrix[row][col - 1] == 'S')
                                {
                                    matrix[row][col] = '.';
                                    Console.WriteLine($"Sam died at {samRow}, {samCol}");
                                    matrix[samRow][samCol] = 'X';
                                    PrintMatrix(matrix);
                                    return;
                                }
                                else
                                {
                                    matrix[row][col - 1] = 'd';
                                    matrix[row][col] = '.';
                                    break;
                                }
                            }
                        }

                    }
                }
                switch (command)
                {
                    case 'U':
                        if (samRow - 1 == nikRow)
                        {
                            matrix[samRow][samCol] = '.';
                            matrix[samRow - 1][samCol] = 'S';
                            matrix[nikRow][nikCol] = 'X';
                            Console.WriteLine("Nikoladze killed!");
                            PrintMatrix(matrix);
                            return;
                        }
                        else
                        {
                            matrix[samRow - 1][samCol] = 'S';
                            matrix[samRow][samCol] = '.';
                        }
                        break;

                    case 'D':
                        if (samRow + 1 == nikRow)
                        {
                            matrix[samRow][samCol] = '.';
                            matrix[samRow + 1][samCol] = 'S';
                            matrix[nikRow][nikCol] = 'X';
                            Console.WriteLine("Nikoladze killed!");
                            PrintMatrix(matrix);
                            return;
                        }
                        else
                        {
                            matrix[samRow + 1][samCol] = 'S';
                            matrix[samRow][samCol] = '.';
                        }
                        break;

                    case 'L':

                        matrix[samRow][samCol - 1] = 'S';
                        matrix[samRow][samCol] = '.';
                        break;

                    case 'R':

                        matrix[samRow][samCol + 1] = 'S';
                        matrix[samRow][samCol] = '.';

                        break;

                    case 'W':
                        continue;
                    default:
                        break;
                }
            }
        }
        private static void PrintMatrix(char[][] matrix)
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
