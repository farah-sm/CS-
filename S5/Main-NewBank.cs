using System;
namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("A0123", 1000.50);
            BankAccount account2 = new BankAccount("A0456", 490.10);
            Console.WriteLine("Account " + account1.GetNumber() + " open? " +
           account1.IsOpen());
            Console.WriteLine("Account " + account1.GetNumber() + " balance: " +
           account1.GetBalance());
            Console.WriteLine("Account " + account2.GetNumber() + " open? " +
           account2.IsOpen());
            Console.WriteLine("Account " + account2.GetNumber() + " balance: " +
           account2.GetBalance());
            Console.WriteLine();

            if (account1.IsOpen() && account2.IsOpen())
            {
                account1.Withdraw(50.0);
                account1.MoveAccount(account2);
            }

            Console.WriteLine("Account " + account1.GetNumber() + " open? " +
           account1.IsOpen());
            Console.WriteLine("Account " + account1.GetNumber() + " balance: " +
           account1.GetBalance());
            Console.WriteLine("Account " + account2.GetNumber() + " open? " +
           account2.IsOpen());
            Console.WriteLine("Account " + account2.GetNumber() + " balance: " +
           account2.GetBalance());
        }
    }
}
