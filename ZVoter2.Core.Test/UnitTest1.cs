using System;
using NUnit.Framework;

namespace ZVoter2.Core.Test
{
    [TestFixture]
    public class UnitTest1
    {
        private FirstClass _classUnderTest = new FirstClass();

        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual(2, FirstClass.Sum(1,1));
        }
    }
}
