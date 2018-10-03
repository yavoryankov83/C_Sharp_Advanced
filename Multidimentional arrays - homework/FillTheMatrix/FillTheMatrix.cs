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
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            char number = char.Parse(Console.ReadLine());
            int count = 1;
    
            if (number == 'a')
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    for (int row = 0; row < matrix.GetLength(1); row++)
                    {
                        matrix[col, row] = count++;
                    }
                }
            }
            else if (number == 'b')
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    if (col % 2 == 0)
                    {
                        for (int row = 0; row < matrix.GetLength(1); row++)
                        {
                            matrix[col, row] = count++;
                        }
                    }
                    else
                    {
                        for (int row = matrix.GetLength(1) - 1; row >= 0; row--)
                        {
                            matrix[col, row] = count++;
                        }
                    }
                }
            }
            else if (number == 'c')
            {
                int rows = 0;
                int cols = 0;

                for (int i = matrix.GetLength(1) - 1; i >= 0; i--)
                {
                    rows = i;
                    cols = 0;
                    while (rows < n && cols < n)
                    {
                        matrix[cols++, rows++] = count++;
                    }
                }

                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    rows = j;
                    cols = 0;
                    while (rows < n && cols < n)
                    {
                        matrix[rows++, cols++] = count++;
                    }
                }
            }
            else if (number == 'd')
            {
                int numberToAdd = 1;
                int globalCounter = n;
                int tempValue = -n;
                int sum = -1;

                do
                {
                    tempValue = -1 * tempValue / n;
                    for (int i = 0; i < globalCounter; i++)
                    {
                        sum += tempValue;
                        matrix[sum / n, sum % n] = numberToAdd;
                        numberToAdd++;
                    }
                    tempValue *= n;
                    globalCounter--;
                    for (int i = 0; i < globalCounter; i++)
                    {
                        sum += tempValue;
                        matrix[sum / n, sum % n] = numberToAdd;
                        numberToAdd++;
                    }
                } while (globalCounter > 0);
            }
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    Console.Write("{0}{1}", matrix[row, col], row == n - 1 ? '\n' : ' ');
                }
                //Console.WriteLine();
            }
        }
    }
}
