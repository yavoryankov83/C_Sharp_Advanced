using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArray
{
    class SortingArray
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            ArraySort(arr);
        }

        private static int[] ArraySort(int[] array)
        {
            Array.Sort(array);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            return array;

        }
    }
}
