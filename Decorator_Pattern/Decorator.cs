using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_1216098
{
    internal abstract class Decorator : IComponent
    {
        protected IComponent icmp = null;
        public Decorator(IComponent cmp)
        {
            icmp = cmp;
        }
        abstract public string Welcome();
        abstract public string Welcome(string name);
    }
}
