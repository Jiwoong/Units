﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Units;

namespace UnitsSampleConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Quantity q = new Quantity(1, Unit.None);
            Console.WriteLine(q);

            Console.WriteLine();
            Console.WriteLine("Press ENTER to end.");
            Console.ReadLine();
        }
    }
}
