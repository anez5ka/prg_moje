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
            Console.Write($"poměr stran je {ratio}, obdélník je ");
            if (ratio < 1)
            {
                Console.WriteLine("široký");
            }
            else if (ratio > 1)
            {
                Console.WriteLine("vysoký");
            }
            else Console.WriteLine("čtverec");
            return ratio;
        }


    }
}
