using System;
using System.Collections.Generic;
using System.Linq;

public class IntegerCalculations
{
    public static void Main()
    {
        var arr = ConvertToArray(Console.ReadLine());

        Console.WriteLine(GetMinNumber(arr));
        Console.WriteLine(GetMaxNumber(arr));
        Console.WriteLine("{0:F2}", GetAvarage(arr));
        Console.WriteLine(CalculateSum(arr));
        Console.WriteLine(CalculateProduct(arr));
    }

    private static double GetAvarage(int[] arr)
    {
        double avarage = 0;
        avarage = CalculateSum(arr) / (double)arr.Length;

        return avarage;
    }

    private static long CalculateProduct(int[] arr)
    {
        long product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }

        return product;
    }

    private static long CalculateSum(int[] arr)
    {
        long sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return sum;
    }

    private static int GetMaxNumber(int[] arr)
    {
        int max = int.MinValue;

        Array.Sort(arr);
        max = arr[arr.Length - 1];
        return max;
    }

    private static int GetMinNumber(int[] arr)
    {
        int min = int.MaxValue;

        Array.Sort(arr);
        min = arr[0];
        return min;
    }

    private static int[] ConvertToArray(string number)
    {
        int[] num = number
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        return num;
    }
}

//class IntegerCalculations
//{
//    static void Main()
//    {
//        // TODO: 50/ 100;

//        // input
//        int[] Numbers = Console.ReadLine()
//                        .Trim(' ')          // trim trailing and leading white spaces
//                        .Split(' ')
//                        .Select(number => int.Parse(number))
//                        .ToArray();

//        //Console.WriteLine(Numbers.Min());
//        //Console.WriteLine(Numbers.Max());


//        GetMin(Numbers);
//        GetMax(Numbers);
//        GetAverage(Numbers);
//        GetSum(Numbers);
//        GetProduct(Numbers);
//    }

//    // Get Minimum
//    public static void GetMin(params int[] Numbers)
//    {
//        int MinNumber = int.MaxValue;

//        for (int curNumber = 0; curNumber < Numbers.Length; curNumber++)
//        {
//            if (Numbers[curNumber] < MinNumber)
//            {
//                MinNumber = Numbers[curNumber];
//            }
//        }

//        Console.WriteLine(MinNumber);
//    }

//    // Get Maximum
//    public static void GetMax(params int[] Numbers)
//    {
//        int MaxNumber = int.MinValue;

//        for (int curNumber = 0; curNumber < Numbers.Length; curNumber++)
//        {
//            if (Numbers[curNumber] > MaxNumber)
//            {
//                MaxNumber = Numbers[curNumber];
//            }
//        }

//        Console.WriteLine(MaxNumber);
//    }

//    // Get Average
//    public static void GetAverage(params int[] Numbers)
//    {
//        int NumbersSum = 0;

//        for (int curNumber = 0; curNumber < Numbers.Length; curNumber++)
//        {
//            NumbersSum += Numbers[curNumber];
//        }

//        Console.WriteLine(((double)NumbersSum / (double)Numbers.Length).ToString("F2"));
//    }

//    // Get Sum
//    public static void GetSum(params int[] Numbers)
//    {
//        int NumbersSum = 0;

//        for (int curNumber = 0; curNumber < Numbers.Length; curNumber++)
//        {
//            NumbersSum += Numbers[curNumber];
//        }

//        Console.WriteLine(NumbersSum);
//    }

//    // Get Product
//    public static void GetProduct(params int[] Numbers)
//    {
//        BigInteger NumbersProduct = 1;

//        for (int curNumber = 0; curNumber < Numbers.Length; curNumber++)
//        {
//            NumbersProduct *= Numbers[curNumber];
//        }

//        Console.WriteLine(NumbersProduct);
//    }
//}