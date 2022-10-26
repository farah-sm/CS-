using System;
using System.Collections.Generic;
using System.Text;

namespace Week_4
{
    internal class Person
    {
        private string name;
        private string surname;
        private int yearsOfBirth;
        private string address;

        public Person(string name_args, string surname_args, int yearsofBirth_args)
        {
           name = name_args;
           surname = surname_args;
           yearsOfBirth = yearsofBirth_args;
           address = "";
        }



        public string GetName()
        {
            return name;
        }

        public string GetSurname()
        {
            return surname;
        }

        public int GetYearOfBirth()
        {
            return yearsOfBirth;

        }
        public void SetAddress(string addr)
        {
           address= addr;
        }
        public string GetAddress()
        {
            return address;

        }

        public void Display()
        {
            Console.WriteLine($"Name: {GetName()}");
            Console.WriteLine($"Surname: {GetSurname()}");
            Console.WriteLine($"Year of Birth: {GetYearOfBirth()}");
            Console.WriteLine($"Address:{GetAddress()}");

        }


    }
}
