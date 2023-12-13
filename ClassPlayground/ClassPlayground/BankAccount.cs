using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class BankAccount
    {
        public int accountNumber;
        public string holderName;
        public string currency;
        public double balance;

        public BankAccount(int accountNumber, string holderName, string currency, double balance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.currency = currency;
            this.balance = balance;
        }
        public BankAccount(string holderName, string currency, double balance)
        {
            Random rnd = new Random();
            accountNumber = rnd.Next(100000000, 1000000000);
            this.holderName = holderName;
            this.currency = currency;
            this.balance = balance;
        }
        public BankAccount(string holderName, string currency)
        {
            this.holderName = holderName;  
            this.currency = currency;
            Random rnd = new Random();
            accountNumber = rnd.Next(100000000, 1000000000);
            balance = 0;
        }
        public void Deposit(int amount)
        {
            balance = balance + amount;
        }
        public void Withdraw (int amount)
        {
            if (amount <= balance)
            {
                balance = balance - amount;
            }
        }
        public void Transfer(int amount, BankAccount ToAccount)
        {
            if (balance>=amount)
            {
                balance = balance - amount;
                ToAccount.balance = ToAccount.balance + amount;
            }
        }
        public void Check()
        {
            Console.WriteLine($"{holderName} has {balance} of {currency}");
        }
    }
}
