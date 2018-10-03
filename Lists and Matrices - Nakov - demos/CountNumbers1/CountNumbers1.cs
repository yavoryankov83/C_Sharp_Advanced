using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CountNumbers1
{
    class CountNumbers1
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            list.Sort();

            var start = 0;
            var len = 1;

            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count - 1 || list[i] != list[i + 1])
                {
                    Console.WriteLine(list[start] + " => " + len);
                    start = i + 1;
                    len = 1;
                }
                else
                {
                    len++;
                }
            }
        }
    }
}
