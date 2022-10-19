using Shapes;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Week4
{
    internal class Program
    {

        //static means it can be excecuted without an obbject being allocated
        static void Main(string[] args)
        {


            Point p1 = new Point(9, 8);
            p1.Display();

            Point p2 = new Point(7, 5);
            p2.Display();



            Circle c1 = new Circle(p1, 4.3);
            c1.Display();


            p1.DistanceFrom(p2);

        }
    }


}
