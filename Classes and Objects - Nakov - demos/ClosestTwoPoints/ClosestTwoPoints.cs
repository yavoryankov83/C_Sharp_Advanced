using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{
    class Point
    {
        public int X { get; set; }

        public int Y { get; set; }
    }   

    class ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            Point[] points = ReadPoints();
            Point[] closestTwoPoints = FindClosestTwoPoints(points);

            Console.WriteLine("{0:f3}", CalcDistance(closestTwoPoints[0], closestTwoPoints[1]));
            Console.WriteLine("({0}, {1})", closestTwoPoints[0].X, closestTwoPoints[0].Y);
            Console.WriteLine("({0}, {1})", closestTwoPoints[1].X, closestTwoPoints[1].Y);
        }

        private static Point ReadPoint()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point p = new Point() { X = nums[0], Y = nums[1] };
            return p;
        }

        private static Point[] ReadPoints()
        {
            var n = int.Parse(Console.ReadLine());
            var points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }
            return points;
        }

        static double CalcDistance(Point p1, Point p2)
        {
            var distanceX = Math.Abs(p1.X - p2.X);
            var distanceY = Math.Abs(p1.Y - p2.Y);
            var distance = Math.Sqrt(distanceX * distanceX + distanceY * distanceY);

            return distance;
        }

        private static Point[] FindClosestTwoPoints(Point[] points)
        {
            var minDist = double.MaxValue;
            Point[] result = null;

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    var dist = CalcDistance(points[i], points[j]);
                    if (dist < minDist)
                    {
                        minDist = dist;
                        result = new Point[] { points[i], points[j] };
                    }
                }
            }
            return result;
        }
    }
}
