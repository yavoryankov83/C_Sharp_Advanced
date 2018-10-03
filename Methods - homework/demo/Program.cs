using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 =  { 8, 3, 3 };
            int[] arr2 =  { 6, 2, 4, 2 };

            int[] result = new int[Math.Max(arr1.Length, arr2.Length)];

            for (int i = 0; i < arr2.Length; i++)
            {
                result[i] = arr1[i] + arr2[i];
            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

        }
    }
}
