using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_1216098
{
    internal class StudentProgressReportDirector
    {
        private readonly IStudentReportBuilder _studentProgressReportBuilder;
        public StudentProgressReportDirector(IStudentReportBuilder
       studentProgressReportBuilder)
        {
            _studentProgressReportBuilder = studentProgressReportBuilder;
        }
        public void BuildStudentsProgressReport()
        {
            _studentProgressReportBuilder.BuildHeader();
            _studentProgressReportBuilder.BuildProgress();
            _studentProgressReportBuilder.BuildFooter();
        }
    }
}
