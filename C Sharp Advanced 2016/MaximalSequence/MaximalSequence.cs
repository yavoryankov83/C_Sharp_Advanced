using System;
using System.Linq;

namespace MaximalSequence
{
    class MaximalSequence
    {
        static void Main()
        {
            int arrayLenght = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLenght];

            int maxCount = 0;
            int curentCount = 1;
            int sequenceStart = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (i != 0)
                {
                    if (array[i] == array[i - 1])
                    {
                        curentCount++;
                    }
                    else
                    {
                        curentCount = 1;
                    }
                    if (curentCount > maxCount)
                    {
                        maxCount = curentCount;
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