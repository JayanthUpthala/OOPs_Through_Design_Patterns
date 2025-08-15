using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_1216098
{
    internal class StudentGradeReportDirector
    {
        private readonly IStudentReportBuilder _studentGradeReportBuilder;
        public StudentGradeReportDirector(IStudentReportBuilder studentGradeReportBuilder)
        {
            _studentGradeReportBuilder = studentGradeReportBuilder;
        }
        public void BuildStudentsGradeReport() // order in which components will be built
        {
            _studentGradeReportBuilder.BuildHeader();
            _studentGradeReportBuilder.BuildBody();
            _studentGradeReportBuilder.BuildFooter();
        }

    }
}
