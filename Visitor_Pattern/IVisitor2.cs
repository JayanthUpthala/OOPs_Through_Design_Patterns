using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VisitorPattern_1216098
{
    internal interface IVisitor2<T>
    {
        T Visit(Element2 element);
    }
}
