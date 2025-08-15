using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern_1216098
{
    internal abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
