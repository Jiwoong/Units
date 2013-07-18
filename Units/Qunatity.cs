﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Units
{
    public sealed class Quantity
    {
        private double amount;
        private Unit unit;

        #region Contructor

        public Quantity(double amount, Unit unit)
        {
            this.amount = amount;
            this.unit = unit;
        }

        #endregion

        public Unit Unit
        {
            get { return unit; }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return (this == obj as Quantity);
        }

        public bool Equals(Quantity quantity)
        {
            return (this == quantity);
        }

        #region Operator Overide

        public static bool operator ==(Quantity q1, Quantity q2)
        {
            if (Object.ReferenceEquals(q1, q2))
                return true;
            else if (Object.ReferenceEquals(q1, null))
                return false;
            else if (Object.ReferenceEquals(q2, null))
                return false;

            try
            {
                // Check value
                if (q1.amount != q2.amount)
                    return false;
                if (q1.unit != q2.unit)
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool operator !=(Quantity q1, Quantity q2)
        {
            return !(q1 == q2);
        }

        public static Quantity operator +(Quantity right)
        {
            return right;
        }

        public static Quantity operator +(Quantity left, Quantity right)
        {
            return new Quantity(left.amount + right.To(left.unit).amount, left.unit);
        }
        #endregion

        public override string ToString()
        {
            return amount.ToString() + unit.ToString();
        }

        public Quantity To(Unit unit)
        {
            return UnitManager.Convert(this, unit);
        }

        public Quantity Parse(string str)
        {
            return new Quantity(this.amount, Unit.None);
        }
    }
}
