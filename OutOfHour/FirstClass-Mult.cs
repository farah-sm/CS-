using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Week4
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Mult multiply = new Mult(4, 1);
            Mult multiply1 = new Mult(4, 2);
            Mult multiply2 = new Mult(4, 3);
            Mult multiply3 = new Mult(4, 4);
            Mult multiply4 = new Mult(4, 5);
            Mult multiply5 = new Mult(4, 6);
            Mult multiply6 = new Mult(4, 7);
            Mult multiply7 = new Mult(4, 8);
            Mult multiply8 = new Mult(4, 9);
            Mult multiply9 = new Mult(4, 10);
            Mult multiply10 = new Mult(4, 11);


            multiply.Display();
            multiply1.Display();
            multiply2.Display();
            multiply3.Display();
            multiply4.Display();
            multiply5.Display();
            multiply6.Display();
            multiply7.Display();
            multiply8.Display();
            multiply9.Display();
            multiply10.Display();



        }
        class Mult
        {
            private int x;
            private int y;

            public Mult(int xarg, int yarg)
            {
                x = xarg;
                y = yarg;
            }


        public void Display()
        {
            Console.WriteLine(x * y);
        }




        }
       
      
    }
}
