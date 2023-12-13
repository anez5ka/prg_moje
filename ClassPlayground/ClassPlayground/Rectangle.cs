using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class Rectangle
    {
        public double height;
        public double width;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public double CalculateArea()
        {
            return width * height ;
        }
        public double CalculateAspectRatio()
        {
            double ratio = (height / width);
            ratio = Math.Round(ratio, 3);
            Console.Write($"ratio of sides is {ratio}, rectangle is ");
            if (ratio < 1)
            {
                Console.WriteLine("wide");
            }
            else if (ratio > 1)
            {
                Console.WriteLine("tall");
            }
            else Console.WriteLine("square");
            return ratio;
        }
        public bool ContainsPoint(double x, double y)
        {
            if (x <= width || y <= height)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }


    }
}
