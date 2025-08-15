using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_1216098
{
    abstract class LoanFactory
    {
        public abstract ICreditCheck CreateCreditCheck();
        public abstract IBalanceCheck CreateBalanceCheck();
    }
}
