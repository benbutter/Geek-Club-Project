using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetLib
{
    public class Account : IMoney
    {
        readonly string name;
        
        private decimal balance;

        public decimal GetValue()
        {
            return GetBalance();
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public Account(string name)
        {
            this.name = name;
        }

        public Account(string name, decimal balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException("Deposit amount cannot be negative");

            if (amount == 0)
               throw new ArgumentException("Deposit amount required");

            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > balance)
                throw new ArgumentException("Insufficient Funds");

            if (amount == 0)
                throw new ArgumentException("Withdraw amount required");

            balance -= amount;
        }
    }
}
