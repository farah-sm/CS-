using System;

namespace Week_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Person personOne = new Person("Ahmed", "Farah", 1998);
            Person personTwo = new Person("Ali", "Chand", 1932);

            Console.Write("Person One: What is your address: ");
            personOne.SetAddress(Console.ReadLine());

            Console.Write("Person Two: What is your address: ");
            personTwo.SetAddress(Console.ReadLine());


            personOne.Display();
            personTwo.Display();

        }
    }
}
