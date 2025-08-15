using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern_1216098
{
    [Serializable]
    internal abstract class ProtoTypeBase<T>
    {
        public T Copy()
        {
            MemoryStream mstr = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(mstr, this);
            mstr.Seek(0, SeekOrigin.Begin);
            T cp = (T)bf.Deserialize(mstr);
            return cp;
        }
    }
}
