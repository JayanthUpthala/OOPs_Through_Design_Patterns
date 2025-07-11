﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingApp
{
    internal class GradStudent : Student
    {
        public string Thesis { get; set; }
        public GradStudent(int id, string fname, string lname, int test1, int test2, string thesis) : base(id, fname, lname, test1, test2)
        {
            this.Thesis = thesis;
        }

        public override string ComputeGrade()
        {
            double avg = 0.4 * Test1 + 0.6 * Test2;
            string grade = "";
            if (avg > 92) // more than 92 is an A for a GradStudent
                grade = "A";
            else if (avg > 87)
                grade = "A-";
            else if (avg > 83)
                grade = "B+";
            else if (avg > 75)
                grade = "B";
            else
                grade = "C";
            return grade;
        }
    }
}
