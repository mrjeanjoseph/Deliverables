﻿using System;
using System.Linq;

namespace JoiningDataOOP
{
    public static class DataTableFormatter
    {
        
        public static void tableHeader()
        {
            Console.WriteLine(string.Format("{0, -25}{1, -20}{2, -20}{3, -20}{4, 0}", "Customer", "Item", "Price", "Quantity", "Total"));
            const int tableWidth = 90;
            Console.WriteLine(new string('_', tableWidth));
        }
    }
}
