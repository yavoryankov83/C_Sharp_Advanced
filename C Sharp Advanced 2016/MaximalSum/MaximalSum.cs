using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int maxSum = array[0], currentSum = array[0];
            int start = 0, startTemp = 0, end = 0;

            for (int i = 1; i < array.Length; i++)
            {
                currentSum += array[i];
                if (currentSum < array[i])
                {
                    currentSum = array[i];
                    startTemp = i;
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    start = startTemp;
                    end = i;
                }
            }
            for (int i = start; i <= end; i++)
            {
                Console.Write("{0}", array[i]);
            }
        }
    }
}
