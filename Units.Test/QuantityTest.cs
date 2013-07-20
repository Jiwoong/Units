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
            Quantity q = new Quantity(1, Unit.None);

            Assert.AreEqual(q, q);

            Quantity q1 = new Quantity(1, Unit.None);

            Assert.AreEqual(q, q1);

            Quantity q2 = new Quantity(12, Unit.None);

            Assert.AreNotEqual(q, q2);
        }

        [TestMethod]
        public void AdditionTest()
        {
            Unit u = new Unit("killogram", "kg", SIUnit.SIUnitTypes.Mass);
            Unit g = new Unit("gram", "g", u/1000);
            Quantity q1 = new Quantity(1, u);
            Quantity q2 = new Quantity(2, u);

            Assert.AreEqual(q1 + q2, new Quantity(3, u));
            Assert.AreNotEqual(q1 + q1, new Quantity(3, g));

            Quantity q3 = new Quantity(1000, g);

            Assert.AreEqual(q2, q1+q3);
        }

        [TestMethod]
        public void SubtractionTest()
        {
            Unit u = new Unit("kilogram", "kg", SIUnit.SIUnitTypes.Mass);

            Quantity q1 = new Quantity(1, u);
            Quantity q2 = new Quantity(2, u);

            Assert.AreEqual(q1, q2 - q1);

            Unit g = new Unit("gram", "g", u/1000);

            Quantity q3 = new Quantity(1000, g);

            Assert.AreEqual(q1, q2 - q3);
        }
    }
}
