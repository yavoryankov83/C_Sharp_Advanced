using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{
    class Sales
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
    }

    class SalesReport
    {
        static void Main(string[] args)
        {
            Sales a = ReadSales();
            Console.WriteLine();
        }

        private static Sales ReadSales()
        {
            var items = Console.ReadLine().Split(' ').ToList();

            Sales a = new Sales() { Town = items[0], Product = items[1], Price = double.Parse(items[2]), Quantity = double.Parse(items[3])};

            return a;
        }
    }
}
