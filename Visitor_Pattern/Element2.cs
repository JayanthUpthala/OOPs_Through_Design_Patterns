using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern_1216098
{
    internal abstract class Element2
    {
        public abstract T Accept<T>(IVisitor2<T> visitor);
    }
}
