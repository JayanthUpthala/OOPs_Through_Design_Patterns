using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    internal interface IGradeStrategy
    {
        string ComputeGrade(Student st);
    }
}
