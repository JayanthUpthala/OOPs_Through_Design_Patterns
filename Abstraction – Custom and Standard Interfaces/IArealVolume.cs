using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_1216098
{
    internal interface IArealVolume
    {
        double ComputeCircleArea(double radius);
        double ComputeRectangleArea(double length, double width);
        double ComputeSphereVolume(double radius);
        double CylinderVolume(double radius, double length);

    }
}
