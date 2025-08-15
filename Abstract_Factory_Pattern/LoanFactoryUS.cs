using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_1216098
{
    internal class LoanFactoryUS : LoanFactory
    {
        public override ICreditCheck CreateCreditCheck()
        {
            return new CreditCheckUS();
        }
        public override IBalanceCheck CreateBalanceCheck()
        {
            return new BalanceCheckUS();
        }
    }
}
