using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalBudgetLib;

namespace PersonalBudgetTest
{
    [TestClass]
    public class DepositTest
    {
        
        [TestMethod]
        public void TestAmount()
        {
            Deposit deposit = new Deposit((Decimal)100.11);

            Assert.AreEqual((Decimal)100.11, deposit.GetValue());
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDepositNegativeAmount()
        {
           
            Deposit deposit = null;
            
            try
            {
                decimal amount = -100;
                deposit = new Deposit(amount);
            }
            finally
            {
                Assert.IsNull(deposit);

            }
        }
    }


}
