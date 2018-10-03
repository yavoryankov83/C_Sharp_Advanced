using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class NFactorial
{
    public static int[] Multiply(int[] Number, int Multiplier)
    {
        BigInteger curResult = 0;
        BigInteger carryOver = 0;

        for (int curDigit = 0; curDigit < Number.Length;  curDigit++)
        {
            curResult = Number[curDigit] * Multiplier + carryOver;

            Number[curDigit] = (int)(curResult % 10);

            carryOver = curResult / 10;
        }

        // append the remaining carryover at the end of the array
        if (carryOver > 0)
        {
            // helper
            int oldNumberSize = Number.Length;

            // Step 1: resize the Array to accomodate the 
            // extra digits 
            Array.Resize(ref Number,
            Number.Length + carryOver.ToString().Length);

            int CarryOverLength = carryOver.ToString().Length;

            // Step 2: Append
            for (int curDigit = 0;
                     curDigit < CarryOverLength;
                     curDigit++)
            {
                Number[oldNumberSize + curDigit] = (int)(carryOver % 10);

                carryOver /= 10;
            }
        }

        // results stored in the same 
        // array
        return Number;
    }
    public static string ArrayToString(int[] Number)
    {
        string toPrint = "";

        for (int curDigit = Number.Length - 1;
                 curDigit >= 0;
                 curDigit--)
        {
            toPrint += Number[curDigit].ToString();
        }

        return toPrint;
    }

    static void Main(string[] args)
    {
        int numberN = int.Parse(Console.ReadLine());

        int[] Number = new int[1] { 1 };    // Factorial - > start with 1

        for (int curMultiplier = 1;          // Start with 1
                 curMultiplier <= numberN;   // Multiply the number 
                 curMultiplier++)            // with each next
        {
            Number = Multiply(Number, curMultiplier);
        }

        // Convert Array Number to Regular number
        string toPrint = ArrayToString(Number);

        // output
        Console.WriteLine(toPrint);
    }
}
