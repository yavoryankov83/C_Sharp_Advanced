using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsArray
{
    class NumberAsArray
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            SumOfReversedArrays(array1, array2);
        }
       
        private static void SumOfReversedArrays(int[] arr1, int[] arr2)
        {
            int[] result = new int[Math.Max(arr1.Length, arr2.Length) + 1];
            int reminder = 0;
            for (int i = 0; i < Math.Max(arr1.Length, arr2.Length); i++)
            {
                result[i] = (arr1[i] + arr2[i] + reminder) % 10;
                reminder = (arr1[i] + arr2[i] + reminder) / 10;
            }
            if (arr1.Length > arr2.Length)
            {
                for (int i = arr2.Length; i < arr1.Length; i++)
                {
                    result[i] = (arr1[i] + reminder) % 10;
                    reminder = (arr1[i] + reminder) / 10;
                }
            }
            else if (arr2.Length > arr1.Length)
            {
                for (int i = arr1.Length; i < arr2.Length; i++)
                {
                    result[i] = (arr2[i] + reminder) % 10;
                    reminder = (arr2[i] + reminder) / 10;
                }
            }
            result[Math.Max(arr1.Length, arr2.Length)] = reminder;
            int length = result.Length;
            for (int i = 0; i < length; i++)
            {
                if (i + 1 == length)
                {
                    if (result[i] == 0)
                    {
                        continue;
                    }
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
