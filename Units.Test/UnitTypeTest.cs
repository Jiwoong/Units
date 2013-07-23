using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Units.Test
{
    [TestClass]
    public class UnitTypeTest
    {
        [TestMethod]
        public void ContructionTest()
        {
            UnitType t = new UnitType("kilometer");
        }
    }
}
