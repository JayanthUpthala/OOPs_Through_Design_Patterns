using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern_1216098
{
    internal interface ICheckingActivity
    {
        void WithDrawMoney(double amt);
        void DepositMoney(double amt);
        void AddInterest();    
    }
}
