using System;

namespace Week_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string accNum;
            double balance;
            bool status;

            BankAccount accOne = new BankAccount("ABC123", 200.20);
            BankAccount accTwo = new BankAccount("DEF456");


            // Display the Initial balance
            Console.WriteLine("The balance of both accounts are: ");
            balance = accOne.GetBalance();
            Console.WriteLine($"Account One: {balance}");
            balance = accTwo.GetBalance();
            Console.WriteLine($"Account Two: {balance}");




        }
    }
}
