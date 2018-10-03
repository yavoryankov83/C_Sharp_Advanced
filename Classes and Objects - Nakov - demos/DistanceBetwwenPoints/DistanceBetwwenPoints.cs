using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetwwenPoints
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class DistanceBetwwenPoints
    {
        private static Point ReadPoint()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point p = new Point() { X = nums[0], Y = nums[1] };
            return p;
        }

        static double CalcDistance(Point p1, Point p2)
        {
            var distanceX = Math.Abs(p1.X - p2.X);
            var distanceY = Math.Abs(p1.Y - p2.Y);
            var distance = Math.Sqrt(distanceX * distanceX + distanceY * distanceY);

            return distance;
        }

        static void Main(string[] args)
        {

            //Point p1 = new Point() { X = 6, Y = -2 };
            //Point p2 = new Point() { X = 10, Y = -1 };
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();

            Console.WriteLine("{0:f3}", CalcDistance(p1, p2));
        }
    }
}
