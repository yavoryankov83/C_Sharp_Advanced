using System;
using System.Collections.Generic;
using System.Linq;

class SortingArray
{
    static int GetMax(int[] toSort, int staratAt, int stopAt)
    {
        int MaxNumberIndex = -1;
        int MaxNumber = int.MinValue;
        for (int curElement = staratAt; curElement <= stopAt; curElement++)
        {
            if (toSort[curElement] > MaxNumber)
            {
                MaxNumberIndex = curElement;
                MaxNumber = toSort[curElement];
            }
        }
        return MaxNumberIndex;
    }
    public static int[] SortDescending(int[] toSort)
    {
        for (int CurElement = 0; CurElement < toSort.Length; CurElement++)
        {
            int curMaxIndex = GetMax(toSort, CurElement, toSort.Length - 1);

            if (CurElement != curMaxIndex)
            {
                toSort[CurElement] ^= toSort[curMaxIndex];
                toSort[curMaxIndex] ^= toSort[CurElement];
                toSort[CurElement] ^= toSort[curMaxIndex];
            }
        }

        return toSort;
    }
    public static int[] SortAscending(int[] toSort)
    {
        for (int CurElement = toSort.Length - 1; CurElement >= 0; CurElement--)
        {
            int curMaxIndex = GetMax(toSort, 0, CurElement);

            if (CurElement != curMaxIndex)
            {
                toSort[CurElement] ^= toSort[curMaxIndex];
                toSort[curMaxIndex] ^= toSort[CurElement];
                toSort[CurElement] ^= toSort[curMaxIndex];
            }
        }

        return toSort;
    }
    static void Main(string[] args)
    {
        Console.ReadLine();
        int[] toSort = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        toSort = SortAscending(toSort);
        Console.WriteLine(string.Join(" ", toSort));
        }
    }
