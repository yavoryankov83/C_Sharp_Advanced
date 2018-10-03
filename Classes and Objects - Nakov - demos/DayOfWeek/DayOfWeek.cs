using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            var dateAsString = Console.ReadLine();
            var date = DateTime.ParseExact(dateAsString, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);

            //second way
            //var dateElements = Console.ReadLine().Split(-).Select(int.Parse).ToArray();
            //var dates = new DateTime(dateElements[2], dateElements[1], dateElements[0]);
            //Console.WriteLine(dates.DayOfWeek);

            //Console.WriteLine(string.Format(new CultureInfo("bg-BG"), "{0:d-MM-yyyy}", date));
        }
    }
}
