using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            var phoneBook = new Dictionary<string, string>();

            var input = Console.ReadLine();

            while (input != "search")
            {
                var tokens = input.Split('-');
                var name = tokens[0];
                var number = tokens[1];

                if (!phoneBook.ContainsKey(name))
                {
                    phoneBook.Add(name, number);
                }
                phoneBook[name] = number;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "stop")
            {
                var searched = input;

                if (phoneBook.ContainsKey(searched))
                {
                    Console.WriteLine($"{searched} -> {phoneBook[searched]}");
                }
                else
                {
                    Console.WriteLine($"Contact {searched} does not exist.");
                }

                input = Console.ReadLine();
            }
        }
    }
}
