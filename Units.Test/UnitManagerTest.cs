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
            Quantity kg_1 = new Quantity(1, SIUnit.MassUnits.kg);
            Quantity g_1000 = UnitManager.Convert(kg_1, SIUnit.MassUnits.g);

            Assert.AreEqual(new Quantity(1000, SIUnit.MassUnits.g), g_1000);
        }
    }
}
