using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_1216098
{
    internal interface ICreditCheck
    {
        int GetCreditScore(string firstName, string lastName);
    }
}
