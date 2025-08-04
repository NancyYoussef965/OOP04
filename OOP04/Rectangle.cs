using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{

    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Rectangle(int size)
        {
            Width = size;
            Height = size;
        }
    }
}
