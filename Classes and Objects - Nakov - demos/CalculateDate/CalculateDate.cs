using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDate
{
    class CalculateDate
    {
        static void Main(string[] args)
        {
            DateTime ivoBirthday = new DateTime(1996, 11, 27);
            Console.WriteLine(ivoBirthday);

            DateTime kokiBirthday = new DateTime(2002, 12, 12);
            Console.WriteLine(kokiBirthday);

            var kokiAfter18Month = kokiBirthday.AddMonths(18);
            Console.WriteLine(kokiAfter18Month);

            var diff = kokiBirthday - ivoBirthday;
            Console.WriteLine(diff);
        }
    }
}
