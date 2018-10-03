using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _7.ValidTime
{
    class ValidTime
    {
        static void Main(string[] args)
        {
            var pattern = @"^[01][0-9]:[0-5][0-9]:[0-5][0-9] [A|P]M$";
            var regex = new Regex(pattern);

            var input = Console.ReadLine();

            while (input != "END")
            {
                var line = input;
                var maches = regex.Match(line);

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
