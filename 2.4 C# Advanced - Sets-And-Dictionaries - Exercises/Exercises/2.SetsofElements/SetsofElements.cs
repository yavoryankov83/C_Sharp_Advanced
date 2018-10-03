using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SetsofElements
{
    class SetsofElements
    {
        static void Main(string[] args)
        {
            var result = new HashSet<int>();
            var final = new HashSet<int>();

            var setsNum = Console.ReadLine().Split();

            for (int i = 0; i < int.Parse(setsNum[0]); i++)
            {
                var num = int.Parse(Console.ReadLine());
                result.Add(num);
            }

            for (int i = 0; i < int.Parse(setsNum[1]); i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (result.Contains(num))
                {
                    final.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", final));
        }
    }
}
