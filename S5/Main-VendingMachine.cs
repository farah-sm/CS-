using System;
namespace VendingMachines
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            VendingMachine m1 = new VendingMachine();
            VendingMachine m2 = new VendingMachine(7);

            // Setting Names and Location
            m1.SetName("Machine 1");
            m2.SetName("Machine 2");

            m1.SetLocation("4th Floor");
            m2.SetLocation("Ground Floor");

            // Randomly adding cans to m1 (1 to 10)
            m1.AddCans(r.Next(1, 11));
            Console.WriteLine(m1.ToString());
            Console.WriteLine(m2.ToString());
            Console.WriteLine();

            int tokensToInsert = r.Next(1, 10);
            Console.WriteLine($"Attempting to insert {tokensToInsert} tokens into { m1.GetName()} ");

        if (m1.InsertToken(tokensToInsert))
            {
                Console.WriteLine($"Successfully bought {tokensToInsert} cans from { m1.GetName()}");
 }
            else
            {
                Console.WriteLine("Not enough cans in " + m1.GetName());
            }
            Console.WriteLine();
            Console.WriteLine($"Attempting to insert 1 token into {m1.GetName()}");

            if (m2.InsertToken())
            {
                Console.WriteLine("Successfully bought one can from " + m2.GetName());
            }
            else
            {
                Console.WriteLine("Not enough cans in " + m2.GetName());
            }
            Console.WriteLine();

            if (m1.GetCans() <= 3)
            {
                Console.WriteLine($"Refill {m1.ToString()}");
            }
            if (m2.GetCans() <= 3)
            {
                Console.WriteLine($"Refill {m2.ToString()}");
            }
        }
    }
}
