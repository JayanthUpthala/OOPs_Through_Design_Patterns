namespace GradingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcessGrades_Click(object sender, EventArgs e)
        {
            try
            {
                string inputFile = "D:\\UB\\CPSC501 - OOPs\\Assignment1\\data\\StudentsData.txt";
                string outputFile = "D:\\UB\\CPSC501 - OOPs\\Assignment1\\data\\StudentGrades.txt";
                ProcessGrades pg = new ProcessGrades();
                pg.ReadStudentData(inputFile);
                pg.ProcessAndWriteGrades(outputFile);
                MessageBox.Show("Grades processed, examine file " + outputFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}