using NUnit.Framework;
using System;

namespace Tasky.Core.Test
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            Assert.AreEqual(4, 2 + 2);
        }
    }
}

