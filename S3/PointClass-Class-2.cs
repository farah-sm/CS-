using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle
    {

        //
        private Point centre;
        private double radius;


        public Circle(Point c, double r)
        {
            centre = c;
            radius = r;
        }

        public void Display()
        {
            centre.Display();
            Console.WriteLine($"Radius is: {radius}");


        }

    }
}

