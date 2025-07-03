using DBStudentApp_1216098.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStudentApp_1216098.DataLayer
{
    internal interface IRepository
    {
        List<Course> GetAllCourses();
        List<Enrollment> GetEnrollment(string courseNum);
    }
}
