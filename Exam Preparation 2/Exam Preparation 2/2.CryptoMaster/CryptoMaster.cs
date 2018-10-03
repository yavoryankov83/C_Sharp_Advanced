using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CryptoMaster
{
    class CryptoMaster
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var maxTurns = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                for (int j = 0; j < nums.Count; j++)
                {
                    var turns = 1;

                    var currElementIndex = j;
                    var nextElementIndex = (currElementIndex + i) % nums.Count;

                    while (nums[currElementIndex] < nums[nextElementIndex])
                    {
                        currElementIndex = nextElementIndex;
                        nextElementIndex = (currElementIndex + i) % nums.Count;
                        turns++;
                    }

                    if (turns > maxTurns)
                    {
                        maxTurns = turns;
                    }
                }
            }
            Console.WriteLine(maxTurns);
        }
    }
}
