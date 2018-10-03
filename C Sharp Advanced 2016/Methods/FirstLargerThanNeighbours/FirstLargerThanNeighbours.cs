using System;
using System.Collections.Generic;
using System.Linq;

class FirstLargerThanNeighbours
{
    static bool IndexOfLargerElement(int firstNumber, int currentNumber, int secondNumber)
    {
        if (currentNumber > firstNumber && currentNumber > secondNumber)
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
        Console.ReadLine();
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (IndexOfLargerElement(array [i - 1], array [i], array [i + 1]))
            {
                Console.WriteLine(i);
                return;
            }
        }
        Console.WriteLine("-1");
        
    }
}
