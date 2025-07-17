using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal interface IBridge
    {
        string OperationImp();
        string AnotherOperationImp(string msg);
    }
}
