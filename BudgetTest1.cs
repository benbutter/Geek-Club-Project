using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalBudgetLib;
using System.Collections.Generic;

namespace PersonalBudgetTest
{
    [TestClass]
    public class BudgetTest1
    {
        [TestMethod]
        public void GetAvailableBalanceTest1()
        {
            Budget budget = new Budget();
            List<IMoney> monies = new List<IMoney>();

            monies.Add(new FakeMoney(100));
            monies.Add(new FakeMoney(200));

            decimal result = budget.GetAvailableBalance(monies);

            Assert.AreEqual(300, result);

         }

        [TestMethod]
        public void GetAvailableBalanceNegativeTest()
        {
            Budget budget = new Budget();
            List<IMoney> monies = new List<IMoney>();

            monies.Add(new FakeMoney(-100));
            monies.Add(new FakeMoney(-200));

            decimal result = budget.GetAvailableBalance(monies);

            Assert.AreEqual(-300, result);

        }

    }

  

   

    public class FakeMoney : IMoney
    {
        private decimal value;

        public FakeMoney(decimal value)
        {
            this.value = value;
        }

        public decimal GetValue()
        {
            return value;
        }
    }
}
