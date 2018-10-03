using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.FindEvensorOdds
{
    class FindEvensorOdds
    {
        static void Main(string[] args)
        {
            var range = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var start = range[0];
            var end = range[1];

            var command = Console.ReadLine();

            Predicate<int> predict;


            if (command == "even")
            {
                predict = n => n % 2 == 0;
            }
            else
            {
                predict = n => n % 2 != 0;
            }

            var result = PredicateNums(start, end, predict);
            Console.WriteLine(string.Join(" ", result));
            
        }

        private static List<int> PredicateNums(int start, int end, Predicate<int> predict)
        {
            var result = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (predict(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
