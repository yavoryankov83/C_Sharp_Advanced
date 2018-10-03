using System;
using System.Collections.Generic;
using System.Linq;

class EnglishDigit
{
    static string ReturnWordForLastDigit(int number)
    {
        string[] words = "zero one two three four five six seven eight nine".Split(' ');
        return words[number % 10];
    }

    static void Main(string[] args)
    {
        int inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(ReturnWordForLastDigit(inputNumber));
    }
}
