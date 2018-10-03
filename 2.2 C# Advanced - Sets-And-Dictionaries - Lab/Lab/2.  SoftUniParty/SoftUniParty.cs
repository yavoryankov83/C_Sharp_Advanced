using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SoftUniParty
{
    class SoftUniParty
    {
        static void Main(string[] args)
        {
            var guests = new SortedSet<string>();

            var input = Console.ReadLine();

            while (input != "PARTY")
            {
                guests.Add(input);

                input = Console.ReadLine();
            }

            while (input != "END")
            {
                guests.Remove(input);

                input = Console.ReadLine();
            }

            Console.WriteLine(guests.Count);

            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
