using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Units.SIUnit
{
    public static class SIUnitTypes
    {
        public static readonly UnitType Mass = new UnitType("kilogram");
        public static readonly UnitType Length = new UnitType("meter");
        public static readonly UnitType Time = new UnitType("second");
    }

    public static class MassUnits
    {
        public static readonly Unit kg = new Unit("kilogram", "kg", SIUnitTypes.Mass);
        public static readonly Unit g = new Unit("gram", "g", kg/1000);
    }
}
