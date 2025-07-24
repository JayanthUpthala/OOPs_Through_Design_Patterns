using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_1216098
{
    internal class ComponentDerivedTime : Component
    {
        public override string Welcome()
        {
            return base.Welcome() + "\nTime = " + DateTime.Now;
        }

    }
}
