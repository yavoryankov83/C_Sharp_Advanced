using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class MyRectangle
    {
        public int Top { get; set; }

        public int Left { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public double CalcArea()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return string.Format("Rect({0}, {1}, width={2}, height={3})", Left, Top, Width, Height);
        }
    }

    class Rectangle
    {
        static void Main(string[] args)
        {
            MyRectangle rec = new MyRectangle() { Left = 3, Top = -4, Width = 10, Height = 12};
            Console.WriteLine(rec);

            MyRectangle rec2 = new MyRectangle() { Left = 3, Top = -4, Width = 10, Height = 12 };
            Console.WriteLine(rec2);
            Console.WriteLine(rec2.CalcArea());
        }
    }
}
