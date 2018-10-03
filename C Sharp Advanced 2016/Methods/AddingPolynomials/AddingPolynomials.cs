using System;
using System.Collections.Generic;
using System.Linq;

class AddingPolynomials
{
    static int[] SumPolinomus(int[] arrayA, int[] arrayB)
    {
        int[] result = new int[Math.Max(arrayA.Length, arrayB.Length)];
        int digitA = 0;
        int digitB = 0;
        for (int curDigit = 0; curDigit < Math.Max(arrayA.Length, arrayB.Length); curDigit++)
        {
            try { digitA = arrayA[curDigit]; }
            catch (IndexOutOfRangeException)
            { digitA = 0; }


            try { digitB = arrayB[curDigit]; }
            catch (IndexOutOfRangeException)
            { digitB = 0; }

            result[curDigit] = digitA + digitB;
        }
        return result;
    }

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] polinom1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] polinom2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[] sum = SumPolinomus(polinom1, polinom2);
        string toPrint = string.Join(" ", sum);
        Console.WriteLine(toPrint);
    }
}
