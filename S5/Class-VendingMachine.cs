using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachines
{
    internal class VendingMachine
    {
        private string name;
        private string location;

        private int can;
        private int tokens;


        public VendingMachine(int c)
        {
            this.can = c;
            this.tokens = 0;
            name = "default name";
            location = "default locatoin";
        }

        public VendingMachine()
             : this(0)
        {

        }


        public void SetName(string n)
        {
            name = n;
        }

        public void SetLocation(string l)
        {
            location = l;
        }

        public void AddCans(int c)
        {
            can += c;
        }



        public bool InsertToken(int t)
        {
            if (t <= can)
            {
                tokens += t;
                can -= t;
                return true;
            }
            return false;
        }

        public bool InsertToken()
        {
            return this.InsertToken(1);
        }

        public int GetCans()
        {
            return can;
        }

        public string GetName()
        {
            return name;
        }

        public string ToString()
        {
            return $"Name: {name} " +
                   $"Location: {location} " +
                   $"Cans left: {can} " +
                   $"Tokens: {tokens} ";
        }
    }
}

