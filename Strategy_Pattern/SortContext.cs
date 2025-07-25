using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class SortContext
    {
        IStrategySort<Student> istrat = null;
        public SortContext(IStrategySort<Student> ist)
        {
            istrat = ist;
        }
        // algorithm interface
        public void DoSort(List<Student> TList)
        {
            istrat.DoSort(TList);
        }
    }
}
