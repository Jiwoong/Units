using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Units
{
    /// <summary>
    /// The UnitManager class provides services around unit naming and identification.
    /// </summary>
    /// <remarks>
    /// The UnitManager class contains static methods that access a singleton instance of the class
    /// </remarks>
    public sealed class UnitManager
    {
        private static UnitManager instance;
        public static UnitManager Instance
        {
            get
            {
                if (UnitManager.instance == null)
                {
                    UnitManager.instance = new UnitManager();
                }

                return UnitManager.instance;
            }
        }

        public static Quantity Convert(Quantity quantity, Unit toUnit)
        {
            try
            {
                if (Object.ReferenceEquals(quantity.Unit, toUnit))
                {
                    return quantity;
                }

                if (quantity.Unit.IsCompatibleTo(toUnit))
                {
                    return new Quantity(quantity.Amount * quantity.Unit.Factor / toUnit.Factor, toUnit);
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
