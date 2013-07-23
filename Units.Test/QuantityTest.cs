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


            Quantity kg = new Quantity(1, SIUnit.MassUnits.kg);
            Quantity g = new Quantity(1000, SIUnit.MassUnits.g);

            Assert.AreEqual(kg, g);


        }

        [TestMethod]
        public void AdditionTest()
        {
            Quantity q1 = new Quantity(1, SIUnit.MassUnits.kg);
            Quantity q2 = new Quantity(2, SIUnit.MassUnits.kg);

            Assert.AreEqual(new Quantity(3, SIUnit.MassUnits.kg), q1 + q2);
            Assert.AreEqual(new Quantity(3, SIUnit.MassUnits.kg), q2 + q1);

            Quantity q3 = new Quantity(1000, SIUnit.MassUnits.g);

            Assert.AreEqual(new Quantity(2, SIUnit.MassUnits.kg), q1+q3);
            Assert.AreEqual(new Quantity(2, SIUnit.MassUnits.kg), q3+q1);
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

        [TestMethod]
        public void MultiplicationTest()
        {
            Quantity q1 = new Quantity(1, SIUnit.MassUnits.kg);

            Assert.AreEqual(new Quantity(123, SIUnit.MassUnits.kg), 123 * q1);
            Assert.AreEqual(new Quantity(123, SIUnit.MassUnits.kg), q1 * 123);

            Quantity q2 = new Quantity(10, SIUnit.MassUnits.kg);

            Assert.AreEqual(new Quantity(10, SIUnit.MassUnits.kg * SIUnit.MassUnits.kg), q1 * q2);
            Assert.AreEqual(new Quantity(10, SIUnit.MassUnits.kg * SIUnit.MassUnits.kg), q2 * q1);

            Quantity q3 = new Quantity(1000, SIUnit.MassUnits.g);
            Assert.AreEqual(new Quantity(1000, SIUnit.MassUnits.kg * SIUnit.MassUnits.g), q1 * q3);
            Assert.AreEqual(new Quantity(1000, SIUnit.MassUnits.g * SIUnit.MassUnits.kg), q3 * q1);

        }
    }
}
