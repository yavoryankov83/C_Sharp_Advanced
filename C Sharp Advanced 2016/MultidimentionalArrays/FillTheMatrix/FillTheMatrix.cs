using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheMatrix
{
    class FillTheMatrix
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            char pattern = (char)Console.Read();

            int[,] matrix = new int[N, N];
            int currentNumber = 1;
            if (Char.ToUpper(pattern).Equals('A'))
            {
                for (int col = 0; col < N; col++)
                {
                    for (int row = 0; row < N; row++)
                    {
                        matrix[row, col] = currentNumber;
                        currentNumber++;
                    }
                }
            }
            else if (Char.ToUpper(pattern).Equals('B'))
            {
                for (int col = 0; col < N; col++)
                {
                    if (col % 2 == 0)
                    {
                        for (int row = 0; row < N; row++)
                        {
                            matrix[row, col] = currentNumber;
                            currentNumber++;
                        }
                    }
                    else
                    {
                        for (int row = N - 1; row >= 0; row--)
                        {
                            matrix[row, col] = currentNumber;
                            currentNumber++;
                        }
                    }
                }
            }
            else if (Char.ToUpper(pattern).Equals('C'))
            {
                for (int col = 0; col < N; col++)
                {
                    if (col % 2 == 0)
                    {
                        for (int row = 0; row < N; row++)
                        {
                            matrix[row, col] = currentNumber;
                            currentNumber++;
                        }
                    }
                    else
                    {
                        for (int row = N - 1; row >= 0; row--)
                        {
                            matrix[row, col] = currentNumber;
                            currentNumber++;
                        }
                    }
                }
            }
            else if (Char.ToUpper(pattern).Equals('D'))
            {
                for (int col = 0; col < N; col++)
                {
                    if (col % 2 == 0)
                    {
                        for (int row = 0; row < N; row++)
                        {
                            matrix[row, col] = currentNumber;
                            currentNumber++;
                        }
                    }
                    else
                    {
                        for (int row = N - 1; row >= 0; row--)
                        {
                            matrix[row, col] = currentNumber;
                            currentNumber++;
                        }
                    }
                }
            }
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    Console.Write("{0,1} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
