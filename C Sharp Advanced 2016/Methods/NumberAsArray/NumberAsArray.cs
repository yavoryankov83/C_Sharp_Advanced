using System;
using System.Collections.Generic;
using System.Linq;

class NumberAsArray
{
    public static int GetNumber(string InputFormat)
    {
        string tempString = "";

        InputFormat = InputFormat.Replace(" ", "");

        for (int digit = InputFormat.Length - 1;
                 digit >= 0;
                 digit--)
        {
            tempString += InputFormat[digit];
        }

        return int.Parse(tempString);
    }

    public static string GetString(int Number)
    {
        string OutputFormat = "";

        string NumToString = Number.ToString();

        for (int digit = NumToString.Length - 1;
                 digit >= 0;
                 digit--)
        {
            OutputFormat += NumToString[digit];
            OutputFormat += " ";
        }

        OutputFormat = OutputFormat.TrimEnd(' ');

        return OutputFormat;
    }
    static void Main(string[] args)
    {
        Console.ReadLine().Split(' ').Select(int.Parse);
        string NumberOne = Console.ReadLine();
        string NumberTwo = Console.ReadLine();
        int result = GetNumber(NumberOne) + GetNumber(NumberTwo);
        Console.WriteLine(GetString(result));
    }
}
