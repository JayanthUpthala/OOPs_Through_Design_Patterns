using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_1216098
{
    internal class DecoratorTime : Decorator
    {
        public DecoratorTime(IComponent cmp) : base(cmp)
        {
        }
        public override string Welcome()
        {
            return icmp.Welcome() + "\nTime = " + DateTime.Now.ToString();
        }
        public override string Welcome(string name)
        {
            return icmp.Welcome(name) + "\nTime = " + DateTime.Now.ToString();
        }
    }
}
