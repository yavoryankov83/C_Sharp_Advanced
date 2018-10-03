using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace IntegerCalculations
{
    class IntegerCalculations
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            MinimumElement(nums);
            MaximalElement(nums);
            AverageElement(nums);
            SumOfElements(nums);
            ProductOfElements(nums);
        }

        private static void ProductOfElements(int[] arr)
        {
            BigInteger product = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            Console.WriteLine(product);
        }

        private static void SumOfElements(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }

        private static void AverageElement(int[] arr)
        {
            arr.Average();
            Console.WriteLine("{0:F2}", arr.Average());
        }

        private static void MaximalElement(int[] arr)
        {
            arr.Max();
            Console.WriteLine(arr.Max());
        }

        private static void MinimumElement(int[] arr)
        {
            arr.Min();
            Console.WriteLine(arr.Min());
        }
    }
}
