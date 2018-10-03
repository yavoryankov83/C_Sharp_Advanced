using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindProduct
{
    class FindProduct
    {
        static int FindProducts(params int[] numbers)
        {
            int product = 1;
            foreach (var num in numbers)
            {
                product *= num;
            }
            return product;
        }

        static void Main(string[] args)
        {
            int product1 = FindProducts(1, 3, 5, 6);
            int product2 = FindProducts(9, -5, 6, 5, 78);

            Console.WriteLine(product1);
            Console.WriteLine(product2);
        }
    }
}
