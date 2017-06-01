using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZVoter2.Core.Test
{
    [TestClass]
    public class UnitTest1
    {
        private FirstClass _classUnderTest = new FirstClass();

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, FirstClass.Sum(1,1));
        }
    }
}
