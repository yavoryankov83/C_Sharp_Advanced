using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.FirstName
{
    class FirstName
    {
        static void Main(string[] args)
        {
            var result = new HashSet<string>();

            var names = Console.ReadLine().Split();

            var letters = Console.ReadLine().Split();

            foreach (var lett in letters)
            {
                foreach (var name in names)
                {
                    if (name.ToUpper().StartsWith(lett.ToUpper()))
                    {
                        result.Add(name);
                    }
                }
            }
            if (result.Count() != 0)
            {
                Console.WriteLine(result.OrderBy(w => w).FirstOrDefault());
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
