using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class MathAdapter2 : IMathTarget
    {
        ExistingAdaptee ema = null;
        public MathAdapter2()
        {
            ema = new ExistingAdaptee();
        }
        public double ComputeAvgNew(double[] Arr)
        {
            if (Arr.Length == 3)
                return ema.ComputeAvg((float)Arr[0], (float)Arr[1],
                (float)Arr[2]);
            else if (Arr.Length == 4)
                return ema.ComputeAvg((float)Arr[0], (float)Arr[1],
                (float)Arr[2], (float)Arr[3]);
            else
                throw new Exception("Array size is not currently supported for ComputeAvg");
        }
       
        public int ComputeAvgRound(double[] Arr)
        {
            if (Arr.Length == 3)
                return (int)Math.Round(ema.ComputeAvg((float)Arr[0],
                (float)Arr[1], (float)Arr[2]));
            else if (Arr.Length == 4)
                return (int)Math.Round(ema.ComputeAvg((float)Arr[0],
                (float)Arr[1], (float)Arr[2], (float)Arr[3]));
            else throw new Exception("Array size is not currently supported for ComputeAvg");
        }
        public double FindMinNew(double[] Arr)
        { // to do – your implementation
            throw new NotImplementedException();
        }

    }
}
