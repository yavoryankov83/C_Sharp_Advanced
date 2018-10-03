using System;
using System.Linq;

class GetLargestNumber
{
    static int GetMax(int a, int b)
    {
        if (a >= b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        int MaxValue = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            MaxValue = GetMax(numbers[i], MaxValue);
        }

        Console.WriteLine(MaxValue);
    }
}
