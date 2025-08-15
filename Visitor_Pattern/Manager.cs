using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern_1216098
{
    internal class Manager : Employee
    {
        public Manager(string nm, int vacDays, double pay) : base(nm, vacDays, pay)
        {
        }
    }
}
