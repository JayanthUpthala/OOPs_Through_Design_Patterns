﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_1216098
{
    internal class StockInfo
    {
        public StockInfo(string sym, double pr)
        {
            symbol = sym; 
            price = pr;
        }


        string symbol; // subject info
        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }
        double price; // subject info

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public override string ToString()
        {
            return symbol + " : " + price.ToString();
        }
    }
}
