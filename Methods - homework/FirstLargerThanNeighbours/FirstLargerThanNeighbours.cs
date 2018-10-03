using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(FirstLargerElement(array));
        }

        private static int FirstLargerElement(int[] arr)
        {
            int index = -1;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
