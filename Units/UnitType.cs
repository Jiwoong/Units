using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Units
{
    public class UnitType
    {
        private static UnitType none = new UnitType("none");
        public static UnitType None
        {
            get
            {
                return none;
            }
        }

        private string unitTypeName;
        public UnitType(string unitTypeName)
        {
            this.unitTypeName = unitTypeName;
        }

        public static UnitType operator *(UnitType left, UnitType right)
        {
            return left;
        }

    }
}
