using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_1216098
{
    internal interface IObserver
    {
        void Notify(StockInfo sinfo);
    }
}
