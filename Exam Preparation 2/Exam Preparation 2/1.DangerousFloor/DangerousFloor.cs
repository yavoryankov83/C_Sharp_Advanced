using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DangerousFloor
{
    class DangerousFloor
    {
        static int rows = 8;
        static int cols = 8;

        static void Main(string[] args)
        {
            var board = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                board[row] = Console.ReadLine().Split(',').Select(char.Parse).ToArray();

            }

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                var inputSplit = input.Split('-');

                var piece = inputSplit[0][0];

                var currRowPos = (inputSplit[0][1] - '0');
                var currColPos = (inputSplit[0][2] - '0');

                var posRowPos = (inputSplit[1][0] - '0');
                var posColPos = (inputSplit[1][1] - '0');

                if (board[currRowPos][currColPos] != piece)
                {
                    Console.WriteLine("There is no such a piece!");
                }
                else
                {
                    if (!IsValidMove(piece, currRowPos, currColPos, posRowPos, posColPos, board))
                    {
                        Console.WriteLine("Invalid move!");
                    }
                    else if (!IsInsideBoard(posRowPos, posColPos, board))
                    {
                        Console.WriteLine("Move go out of board!");
                    }
                }
            }
        }
        static bool IsValidMove(char piece, int currRowPos, int currColPos, int posRowPos, int posColPos, char[][] board)
        {
            switch (piece)
            {
                case 'K':
                    if (currRowPos == posRowPos && Math.Abs(currColPos - posColPos) == 1 //horizontal with one position
                        || currColPos == posColPos && Math.Abs(currRowPos - posRowPos) == 1 //vertical with one position
                        || (Math.Abs(currRowPos - posRowPos) == 1 && Math.Abs(currColPos - posColPos) == 1) //diagonal with one position
                        )
                    {
                        if (IsInsideBoard(posRowPos, posColPos, board))
                        {
                            board[posRowPos][posColPos] = piece;
                            board[currRowPos][currColPos] = 'x';
                        }

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 'P':
                    if (currColPos == posColPos && currRowPos - posRowPos == 1) //only up with one position
                    {
                        if (IsInsideBoard(posRowPos, posColPos, board))
                        {
                            board[posRowPos][posColPos] = piece;
                            board[currRowPos][currColPos] = 'x';
                        }

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 'B':
                    if (Math.Abs(currRowPos - posRowPos) >= 1 && Math.Abs(currColPos - posColPos) >= 1) //diagonal move 
                    {
                        if (IsInsideBoard(posRowPos, posColPos, board))
                        {
                            board[posRowPos][posColPos] = piece;
                            board[currRowPos][currColPos] = 'x';
                        }

                        return true; 
                    }
                    else
                    {
                        return false;
                    }
                case 'Q':
                    if (currRowPos == posRowPos && Math.Abs(currColPos - posColPos) >= 1 //horizontal with one position
                        || currColPos == posColPos && Math.Abs(currRowPos - posRowPos) >= 1 //vertical with one position
                        || (Math.Abs(currRowPos - posRowPos) >= 1 && Math.Abs(currColPos - posColPos) >= 1)) //diagonal with one position
                    {
                        if (IsInsideBoard(posRowPos, posColPos, board))
                        {
                            board[posRowPos][posColPos] = piece;
                            board[currRowPos][currColPos] = 'x';
                        }

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 'R':
                    if ((currRowPos == posRowPos && Math.Abs(currColPos - posColPos) >= 1 //horizontal with one position
                        || currColPos == posColPos && Math.Abs(currRowPos - posRowPos) >= 1)) //vertical with one position 
                    {
                        if (IsInsideBoard(posRowPos, posColPos, board))
                        {
                            board[posRowPos][posColPos] = piece;
                            board[currRowPos][currColPos] = 'x';
                        }
                        
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default: throw new NotImplementedException();
            }
        }
        static bool IsInsideBoard(int posRowPos, int posColPos, char[][] board)
        {
            var validRows = posRowPos >= 0 && posRowPos <= board.Length - 1;
            var validCols = posColPos >= 0 && posColPos <= board.Length - 1;

            return validRows && validCols;
        }
    }
}
