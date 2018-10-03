using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePoint
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class CreatePoint
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.X = 3;
            p.Y = 4;
            Console.WriteLine("({0}, {1})", p.X, p.Y);
        }
    }
}
