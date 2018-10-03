using System;
using System.Linq;

namespace MaximalKSum
{
    class MaximalKSum
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int K = int.Parse(Console.ReadLine());
            int maxSum = 0;
            int currentSum = 0;
            int firstSequence = 0;

            for (int index = 0; index < N + 1 - K; index++)
            {
                for (int add = 0; add < K; add++)
                {
                    currentSum += array[index + add];
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    firstSequence = index;
                }
                currentSum = 0;
            }

            Console.Write("The {0} consecutive elements with maximum sum are: ", K);
            for (int index = firstSequence; index < firstSequence + K; index++)
            {
                Console.Write("{0} ", array[index]);
            }
        }
    }
}
