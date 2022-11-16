using AddressProject;
using System;
using System.Collections.Generic;
using System.Text;


namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3];
            people[0] = new Person("James", "Brown", 1990);
            people[1] = new Person("Frederic", "Chopin", 1810);
            people[2] = new Person("Tom", "Jones", 1940);

            // this will generate a null reference Exception
            // because the address attribute has not been set yet
            foreach (Person p in people)
                p.Display();
            people[0].SetAddress("30 Hampstead Ln; London; N6 4NX");
            people[1].SetAddress("25 Castlegate; Knaresborough; HG5 8AR");
            people[2].SetAddress("59 Pier Rd; Littlehampton; BN17 5LP");
            foreach (Person p in people)
                p.Display();
        }
    }
}
