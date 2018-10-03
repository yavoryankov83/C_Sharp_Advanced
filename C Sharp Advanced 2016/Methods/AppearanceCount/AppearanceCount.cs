using System;
using System.Collections.Generic;
using System.Linq;

class AppearanceCount
{
    static int CountNumbers(int[] number, int X)
    {
        int appearanceCounter = 0;
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == X)
            {
                appearanceCounter++;
            }
        }
        return appearanceCounter;
    }
    static void Main(string[] args)
    {
        int.Parse(Console.ReadLine());
        int[] number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int X = int.Parse(Console.ReadLine());
        Console.WriteLine(CountNumbers(number, X));
    }
    
}
