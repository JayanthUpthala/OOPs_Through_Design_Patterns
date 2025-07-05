using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_1216098
{
    internal class GenUtils
    {
        public static void Exchange<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        //public static void Exchange<T>(ref double a, ref double b)
        //{
        //    double temp = a;
        //    a = b;
        //    b = temp;
        //}
    }
}
