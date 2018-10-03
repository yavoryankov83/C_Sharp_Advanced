using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Fixemails
{
    class Fixemails
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, string>();

            var command = Console.ReadLine();

            while (command != "stop")
            {
                var name = command;
                var email = Console.ReadLine();
                var last = email.Split('.');
                var end = last[1];

                if (end != "us" && end != "uk")
                {
                    book.Add(name, email);
                }
                command = Console.ReadLine();
            }

            foreach (var pair in book)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
