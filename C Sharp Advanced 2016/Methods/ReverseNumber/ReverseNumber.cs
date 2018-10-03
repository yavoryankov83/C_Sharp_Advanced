using System;
using System.Collections.Generic;
using System.Linq;

class ReverseNumber
{
    static string ReverseDigits(string toReverse)
    {
        string Reversed = "";
        for (int i = toReverse.Length - 1; i >= 0; i--)
        {
            Reversed += toReverse[i];
        }
        return Reversed;
    } 
    static void Main(string[] args)
    {
        string toReverse = Console.ReadLine();
        bool isNegativ = false;

        if (toReverse.Contains("-"))
        {
            isNegativ = true;
            toReverse = toReverse.Remove('-');
        }
        if (!isNegativ)
        {
            Console.WriteLine(ReverseDigits(toReverse));
        }
        else
        {
            Console.WriteLine("-" + (ReverseDigits(toReverse)));
        }
    }
}
