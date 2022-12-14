using System;

namespace Hospital
{
    public class Therapy : IPrintable, IPrescribable
    {
        private string name;
        private string[] medications;
        private int numOfMedications;

        public Therapy(string n, string[] m)
        {
            name = n;
            medications = m;
        }

        public Therapy(string n) : this(n, new string[10]) { }


        public void PrescribeMedication(string m)
        {
            if (numOfMedications < medications.Length)
            {
                medications[numOfMedications++] = m;
            }

        }


        public void DeprescribeMedication(string m)
        {
            for (int i = 0; i < numOfMedications; i++)
            {
                if (medications[i].Equals(m))
                {
                    for (int j = i; j < numOfMedications - 1; j++)
                    {
                        medications[j] = medications[j + 1];
                    }
                    numOfMedications--;

                    break;
                }
            }
        }


        public bool IsPrescribed(string m)
        {
            for (int i = 0; i < numOfMedications; i++)
            {
                if (medications[i].Equals(m))
                    return true;
            }

            return false;
        }

        public void Print()
        {
            Console.WriteLine("Name:" + name);
            Console.Write("Medications:");
            for (int i = 0; i < numOfMedications; i++)
                Console.Write(medications[i] + " ");
            Console.WriteLine();
        }
    }
}
