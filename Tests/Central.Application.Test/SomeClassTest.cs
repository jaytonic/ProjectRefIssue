using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Central.Application.Test
{
    [TestFixture]
    public class SomeClassTest
    {
        [Test]
        public void TestSomething()
        {
            SomeClass someClass = new SomeClass();
            int result = someClass.Double(5, 2);

            Assert.AreEqual(10, result);
        }
    }
}
