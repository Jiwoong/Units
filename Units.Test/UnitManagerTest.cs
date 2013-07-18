using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Units.Test
{
    [TestClass]
    public class UnitManagerTest
    {
        [TestMethod]
        public void ConvertTest()
        {
            Unit kg = new Unit("kg", "kg");
            Unit g = new Unit("g", "kg");

            Quantity kg_1 = new Quantity(1, kg);
            Quantity g_1000 = UnitManager.Convert(kg_1, g);

            Assert.AreEqual(kg_1, g_1000);
        }
    }
}
