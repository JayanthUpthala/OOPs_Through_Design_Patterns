using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern_1216098
{
    [Serializable]
    internal class Employee : ProtoTypeBase<Employee>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Branch { get; set; }
        public int EmployeeId { get; set; }
        public Address Addr { get; set; }
    }
}
