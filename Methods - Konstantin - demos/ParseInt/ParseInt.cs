using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseInt
{
    class ParseInt
    {
        static int ParseToInt(string numberAsString)
        {
            int result = 0;

            foreach (char digit in numberAsString)
            {
                result = result * 10 + digit - '0';
            }

            return result;
        }
        static void Main(string[] args)
        {
            int number = ParseToInt("23475");
            Console.WriteLine(number + 5);
        }
    }
}
