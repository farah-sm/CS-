using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    internal class BankAccount
    {
        private string accNum;
        private double balance;


        public BankAccount(string accNum_arg, double balance_arg)
        {
            accNum = accNum_arg;
            balance = balance_arg;
        }

        public BankAccount(string accNum_arg)
        {
            accNum = accNum_arg;
            balance = 0;
        }

        public void Deposit(double amount)
        {
            balance += amount;

        }

        public bool Withdraw(double amount)
        {
            if (balance > amount)
            {
                balance -= amount;
                return true;
            }
            return false;

        }

        public double GetBalance()
        {
            return balance;

        }

        public string GetNumber()
        {
            return accNum;

        }

        public void Close()
        {
            balance = 0;
        }

        public void MoveAccount(BankAccount acc)
        {
            balance += acc.balance;
            acc.Close();

        }

        public bool IsOpen()
        {
            if (balance == 0)
                return false;
            else
                return true;

        }

    }
}
