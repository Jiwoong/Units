using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Units.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CompatibleTest()
        {
            Unit u1 = new Unit("kilogram", "kg", SIUnit.SIUnitTypes.Mass);
            Unit u2 = new Unit("gram", "g", SIUnit.SIUnitTypes.Mass);

            Assert.IsTrue(u1.IsCompatibleTo(u1));
            Assert.IsTrue(u1.IsCompatibleTo(u2));
            Assert.IsTrue(u2.IsCompatibleTo(u1));
            
        }
    }
}
