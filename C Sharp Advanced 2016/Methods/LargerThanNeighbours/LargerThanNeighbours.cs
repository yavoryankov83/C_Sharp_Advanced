using System;
using System.Collections.Generic;
using System.Linq;

class LargerThanNeighbours
{
    static bool ChekLargerElementInArray(int current, int previous, int next)
    {

        if (current > previous && current > next)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main(string[] args)
    {
        int.Parse(Console.ReadLine());
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int counter = 0;
        for (int current = 1; current < array.Length - 1; current++)
        {
            if (ChekLargerElementInArray(array[current], array[current - 1], array[current + 1]))
            {
                counter++;
            }
        }
        Console.WriteLine(counter);

    }
}
