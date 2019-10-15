using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestProject1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Account acc = new Account(200000);

            Assert.IsNotNull(acc);
            Assert.IsNotInstanceOfType(acc, typeof(Account));
            Assert.AreEqual(200000, acc.balance());
                           

        }
    }
}
