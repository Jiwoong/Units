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
    }
}
