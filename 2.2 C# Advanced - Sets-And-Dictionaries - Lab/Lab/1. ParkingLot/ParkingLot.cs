using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ParkingLot
{
    class ParkingLot
    {
        static void Main(string[] args)
        {
            var result = new SortedSet<string>();

            var input = Console.ReadLine();

            while (input != "END")
            {
                var tokens = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "IN")
                {
                    result.Add(tokens[1]);
                }
                else
                {
                    result.Remove(tokens[1]);
                }

                input = Console.ReadLine();
            }

            if (result.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in result)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
