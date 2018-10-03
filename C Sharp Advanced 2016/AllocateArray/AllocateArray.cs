using System;
using System.Linq;

namespace AllocateArray
{
    class AllocateArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiplier = 5;
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = i * multiplier;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
