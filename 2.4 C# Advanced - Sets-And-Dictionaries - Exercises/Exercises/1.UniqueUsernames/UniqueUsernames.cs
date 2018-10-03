using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.UniqueUsernames
{
    class UniqueUsernames
    {
        static void Main(string[] args)
        {
            var namesList = new HashSet<string>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                namesList.Add(name);
            }

            foreach (var name in namesList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
