using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    internal class Rectangle
    {
        public const int numCorner = 4;

        public readonly string Color;

        public Rectangle(string color ="Black")
        {   
            Color = color;
        }
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area()
        {
            return Width * Height;
        }

        public void showDetails()
        {
            Console.WriteLine($"Color : {Color}\nWidth :  {Width}\nHeight : {Height}\nArea: {Area}]\nNumber of Corners : {numCorner}");
        }
    }
}
