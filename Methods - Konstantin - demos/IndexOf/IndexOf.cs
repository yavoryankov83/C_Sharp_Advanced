using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOf
{
    class IndexOf
    {
        static void Main(string[] args)
        {
            char[] symbols = "az sum pesho".ToCharArray();
            char symbol = char.Parse(Console.ReadLine());

            Console.WriteLine("{0} => indeks {1}", symbol, IndexOfElement(symbols, symbol));
        }

        private static int IndexOfElement(char[] symbols, char seekedValue)
        {
            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i] == seekedValue)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
