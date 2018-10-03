using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _6.ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            var pattern = @"^[0-9a-zA-Z_-]{3,16}$";
            var regex = new Regex(pattern);

            var input = Console.ReadLine();

            while (input != "END")
            {
                var lines = input;
                var maches = regex.Match(lines);

                if (maches.Success)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }

                input = Console.ReadLine();
            }
        }
    }
}
