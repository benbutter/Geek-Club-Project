using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetLib
{
    public class Deposit : IMoney
    {
        private decimal amount;
        public string name;

        public Deposit(decimal amount)
        {
            checkAmountDepositIsPositive(amount);
            this.amount = amount;
        }

        public Deposit(decimal amount, string name)
        {
            checkAmountDepositIsPositive(amount);
            this.amount = amount;
            this.name = name;
        }

        private void checkAmountDepositIsPositive(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException("Deposit amount cannot be negative");

            if (amount == 0)
                throw new ArgumentException("Deposit amount required");
        }

        public decimal GetValue()
        {
            return amount;
        }
    }
}
