using System;
using System.Linq;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int index = 0; index <= array.Length - 1; index++)
            {
                int min = index;
                for (int i = index + 1; i < array.Length; i++)
                {
                    if (array[i] < array[min])
                    {
                        min = i;
                    }
                }
                int temp = array[index];
                array[index] = array[min];
                array[min] = temp;
                Console.WriteLine("{0}", array[index]);
            }
            
            }
        }
    }
