using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplatePattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTemplate_Click(object sender, EventArgs e)
        {
            TemplateStudent tst = new StudentProcessingViaFile(@"D:\UB\CPSC501 - OOPs\Assignment8\Data\StudentData.txt", @"D:\UB\CPSC501 - OOPs\Assignment8\Data\StudentDataOut.txt");
            tst.ReadAndProcessStudents();
            // process students via DB
            TemplateStudent tst2 = new StudentProcessingViaDB();
            tst2.ReadAndProcessStudents();
            MessageBox.Show("done processing..");
        }

        private void btnTemplateAndStrategy_Click(object sender, EventArgs e)
        {
            //IGradeStrategy igst = new ComputeGrade4060();
            IGradeStrategy igst = new ComputeGrade5050();
            TemplateStudent tst = new StudentProcessingViaFileV2(@"D:\UB\CPSC501 - OOPs\Assignment8\Data\StudentData.txt", @"D:\UB\CPSC501 - OOPs\Assignment8\Data\StudentDataOut.txt", igst);
            tst.ReadAndProcessStudents();
            MessageBox.Show("done..");
        }
    }
}
