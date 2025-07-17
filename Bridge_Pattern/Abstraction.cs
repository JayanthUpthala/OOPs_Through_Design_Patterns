using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class Abstraction
    {
        protected IBridge bridge;
        public Abstraction(IBridge br) // client's view
        { // uses aggregation
            bridge = br;
        }
        public string Operation()
        {
            return "Abstraction: " + bridge.OperationImp();
        }
        public string OperationGreet(string nm)
        {
            return "Abstraction: " + bridge.AnotherOperationImp(nm);

        }
        }
    }
