using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PeriodicTable
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            var elementsList = new HashSet<string>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var element = Console.ReadLine().Split();

                for (int j = 0; j < element.Length; j++)
                {
                    elementsList.Add(element[j]);
                }
            }

            Console.WriteLine(string.Join(" ", elementsList.OrderBy(x => x)));
        }
    }
}
