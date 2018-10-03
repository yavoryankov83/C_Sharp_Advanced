using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
    class Rectangle
    {
        public double Left { get; set; }

        public double Top { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }
    }

    class RectanglePosition
    {
        static void Main(string[] args)
        {
            Rectangle rec1 = ReadRectangle();
            Rectangle rec2 = ReadRectangle();

            Console.WriteLine(IsInside(rec1, rec2) ? "Inside" : "Outside");
        }

        static Rectangle ReadRectangle()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Rectangle rec = new Rectangle() { Left = nums[0], Top = nums[1], Width = nums[2], Height = nums[3] };

            return rec;
        }
        static bool IsInside(Rectangle rec1, Rectangle rec2)
        {
            var isInside = rec1.Left >= rec2.Left && rec1.Top <= rec2.Top && rec1.Width <= rec2.Width && rec1.Height <= rec2.Height;

            return isInside;
        }
    }
}
