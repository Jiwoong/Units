using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Units
{
    public sealed class Unit : IComparable, IComparable<Unit>, IEquatable<Unit>, IFormattable
    {
        private string name;
        private string symbol;
        private UnitType unitType;
        private double factor;
        #region Contructor

        public Unit(string name, string symbol, UnitType unitType)
            : this(name, symbol, 1.0, unitType)
        {
        }

        public Unit(string name, string symbol, Unit baseUnit)
            : this(name, symbol, baseUnit.factor, baseUnit.unitType)
        {

        }

        private Unit(string name, string symbol, double factor, UnitType unitType)
        {
            this.name = name;
            this.symbol = symbol;
            this.factor = factor;
            this.unitType = unitType;
        }
        #endregion

        public double Factor
        {
            get { return factor; }
        }

        private static Unit none = new Unit(string.Empty, string.Empty, UnitType.None);
        public static Unit None
        {
            get { return Unit.none; }
        }

        public override string ToString()
        {
            return symbol;
        }

        public override int GetHashCode()
        {
            return this.symbol.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return (this == (obj as Unit));
        }
        public bool Equals(Unit unit)
        {
            return (this == unit);
        }

        public static bool operator ==(Unit unit1, Unit unit2)
        {
            if (Object.ReferenceEquals(unit1, unit2))
                return true;

            unit1 = unit1 ?? Unit.None;
            unit2 = unit2 ?? Unit.None;
            return (unit1.name == unit2.name) && (unit1.symbol == unit2.symbol);
        }

        public static bool operator !=(Unit unit1, Unit unit2)
        {
            return !(unit1 == unit2);
        }

        public static Unit operator /(Unit left, double right)
        {
            left = left ?? Unit.None;
            return new Unit(left.name + "/" + right.ToString(), left.symbol + "/" + right.ToString(), left.factor / right, left.unitType);
        }

        public bool IsCompatibleTo(Unit unit)
        {
            if (this.unitType == null || unit.unitType == null)
                return false;
            return this.unitType == (unit ?? Unit.none).unitType;
        }

        #region IComparable 멤버

        int IComparable.CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        int IComparable<Unit>.CompareTo(Unit other)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IEquatable<Unit> 멤버

        bool IEquatable<Unit>.Equals(Unit other)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IFormattable 멤버

        string IFormattable.ToString(string format, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
