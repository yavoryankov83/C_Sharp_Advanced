using System;
using System.Linq;


namespace CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            int lenght1 = int.Parse(Console.ReadLine());
            int[] array1 = new int[lenght1];

            for (int i = 0; i < lenght1; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            int lenght2 = int.Parse(Console.ReadLine());
            int[] array2 = new int[lenght1];

            for (int i = 0; i < lenght2; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            if (lenght1 == lenght2)
            {
                for (int i = 0; i < lenght1; i++)
                {
                    if (array1[i] != array2[i])
                    {
                        Console.WriteLine("Not equal");
                    }
                    else
                    {
                        Console.WriteLine("Equal");
                    }
                }
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}