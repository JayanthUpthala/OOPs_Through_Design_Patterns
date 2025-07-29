using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_1216098
{
    internal class ConcreteStockSubjectGoogle : StockSubject
    {
        public ConcreteStockSubjectGoogle() : base(new StockInfo("Goog", 585))
        {
        }
    }
}
