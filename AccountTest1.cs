using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalBudgetLib;

namespace PersonalBudgetTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class AccountTest1
    {
   
        [TestMethod]
        public void TestDepositBasic()
        {
            Account account = new Account("Cash");

            account.Deposit(100);

            Assert.AreEqual(account.GetBalance(), 100);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDepositNegativeAmount()
        {
            Account account = new Account("Cash");

            try
            {
                account.Deposit(-100);
            }
            finally
            {
                Assert.AreEqual(account.GetBalance(), 0);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDepositNoAmount()
        {
            Account account = new Account("Cash");

            account.Deposit(0);
        }

        [TestMethod]
        public void TestWithdrawBasic()
        {
            Account account = new Account("Cash",100);

            account.Withdraw(100);

            Assert.AreEqual(account.GetBalance(), 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestWithdrawInsufficientFunds()
        {
            Account account = new Account("Cash", 100);

            try
            {
                account.Withdraw(200);
            }
            finally
            {
                Assert.AreEqual(account.GetBalance(), 100);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestWithdrawNoAmount()
        {
            Account account = new Account("Cash");

            account.Withdraw(0);
        }
    }
}
