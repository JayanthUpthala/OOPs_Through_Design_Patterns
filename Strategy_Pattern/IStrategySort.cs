using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal interface IStrategySort<T>
        where T : IComparable, new()
    {
        void DoSort(List<T> TList);
    }
}
