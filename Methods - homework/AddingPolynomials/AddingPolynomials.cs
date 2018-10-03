using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingPolynomials
{
    class AddingPolynomials
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] polinom1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] polinom2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            SumOfPolinoms(polinom1, polinom2);
        }

        private static void SumOfPolinoms(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i] + arr2[i];
            }
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
