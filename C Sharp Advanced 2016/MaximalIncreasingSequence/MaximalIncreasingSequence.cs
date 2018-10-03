using System;
using System.Linq;

namespace MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int maxCount = 0;
            int currentCount = 1;
            int sequenceStart = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (i != 0)
                {
                    if (array[i] > array[i - 1])
                    {
                        currentCount++;
                    }
                    else
                    {
                        currentCount = 1;
                    }
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        sequenceStart = i + 1 - maxCount;
                    }
                }
            }
            for (int i = sequenceStart; i < sequenceStart + maxCount; i++)
            {
                Console.WriteLine("{0}", array[i]);
            }
            Console.WriteLine(maxCount);
        }
    }
}
