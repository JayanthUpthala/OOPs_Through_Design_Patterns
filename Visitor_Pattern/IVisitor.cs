using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VisitorPattern_1216098
{
    internal interface IVisitor
    {
        void Visit(Element element);
    }
}
