namespace BuilderPattern_1216098
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestGradeReport_Click(object sender, EventArgs e)
        {
            var SList = new List<Student>
            {
                new Student { Id= 12341, Major="CS", Name="William Baker", Test1=85, Test2=91},
                new Student { Id= 12342, Major="EE", Name="Sally Simpson", Test1=81, Test2=88},
                new Student { Id= 12343, Major="ME", Name="Mark Mathews", Test1=89, Test2=95},
            };
            var builder = new StudentGradeReportBuilder(SList);
            var director = new StudentGradeReportDirector(builder);
            director.BuildStudentsGradeReport();
            var report = builder.GetReport();
            MessageBox.Show(report.ToString());
        }

        private void btnProgressReport_Click(object sender, EventArgs e)
        {
            var SList = new List<Student>
            {
                new Student { Id= 12341, Major="CS", Name="William Baker", Test1=85},
                new Student { Id= 12342, Major="EE", Name="Sally Simpson", Test1=95},
                new Student { Id= 12343, Major="ME", Name="Mark Mathews", Test1=65},
            };
            var builder = new StudentProgressReportBuilder(SList);
            var director = new StudentProgressReportDirector(builder);
            director.BuildStudentsProgressReport();
            var report = builder.GetReport();
            MessageBox.Show(report.ToString());
        }
    }
}