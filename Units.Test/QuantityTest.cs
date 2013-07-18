using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Units;
namespace Units.Test
{
    [TestClass]
    public class QuantityTest
    {
        [TestMethod]
        public void EqualityTest()
        {
            Quantity q = new Quantity(1, new Unit("test", "t/asd"));

            Assert.AreEqual(q, q);

            Quantity q1 = new Quantity(1, new Unit("test", "t/asd"));

            Assert.AreEqual(q, q1);

            Quantity q2 = new Quantity(12, new Unit("test", "t/asd"));

            Assert.AreNotEqual(q, q2);
        }

        [TestMethod]
        public void AdditionTest()
        {
            Unit u = new Unit("killogram", "kg");
            Unit g = new Unit("gram", "g");
            Quantity q1 = new Quantity(1, u);
            Quantity q2 = new Quantity(2, u);

            Assert.AreEqual(q1 + q2, new Quantity(3, u));
            Assert.AreNotEqual(q1 + q1, new Quantity(3, g));

            Quantity q3 = new Quantity(2, g);
            Quantity sum = q1 + q3;
        }
    }
}
