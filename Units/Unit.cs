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

        #region Contructor

        public Unit(string name, string symbol)
        {
            this.name = name;
            this.symbol = symbol;
        }
        #endregion

        private static Unit none = new Unit(string.Empty, string.Empty);
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

        public bool IsCompatibleTo(Unit unit)
        {
            throw new NotImplementedException();
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
