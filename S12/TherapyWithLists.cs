using System;
using System.Buffers;
using System.Collections.Generic;

namespace Hospital
{
    public class TherapyWithLists : IPrintable, IPrescribable
    {
        private string name;
        List<string> medication;

        public TherapyWithLists(string n)
        {
            name = n;
            medication = new List<string>();
        }


        public void DeprescribeMedication(string m)
        {
            medication.Remove(m);
        }



        public bool IsPrescribed(string m)
        {
            medication.Contains(m);
            return true;
        }

        public void PrescribeMedication(string m)
        {
            medication.Add(m);
        }


        public void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Medications: " );

            foreach (string m in medication)
            {
                Console.Write(m + " ");

            }
            Console.WriteLine();
        }

     

    }

}
