using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Test1 { get; set; }
        public int Test2 { get; set; }
        
        public string ComputeGrade()
        {
            string grade = "";
            double avg = 0.4*Test1 + 0.6*Test2;
            if (avg > 90)
                grade = "A";
            else if (avg > 80)
                grade = "A-";
            else if (avg > 70)
                grade = "B";
            else
                grade = "C";
            return grade;
        }

    }
}
