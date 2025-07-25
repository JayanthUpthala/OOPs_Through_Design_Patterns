namespace ProxyPattern
{
    public partial class Form1 : Form
    {

        List<SubjectMyImage> PList = new List<SubjectMyImage>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPictures.Items.Clear();
            string picfolder = @"D:\UB\CPSC501 - OOPs\Assignment7\MyImages\Images";
            DirectoryInfo di = new DirectoryInfo(picfolder);
            foreach (FileInfo fi in di.GetFiles())
            {
                SubjectMyImage smi = new SubjectMyImage(fi.FullName, fi.Name,
               "Flowers");
                PList.Add(smi);
                cmbPictures.Items.Add(smi.ShortName);
            }
            picfolder = @"D:\UB\CPSC501 - OOPs\Assignment7\MyImages\Images2";
            di = new DirectoryInfo(picfolder);
            foreach (FileInfo fi in di.GetFiles())
            {
                SubjectMyImage smi = new
               SubjectMyImage(fi.FullName, fi.Name, "Mountains");
                PList.Add(smi);
                cmbPictures.Items.Add(smi.ShortName);
            }
        }

        private void cmbPictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnShowImage.Enabled = true;
            string sname = cmbPictures.Text;
            foreach (SubjectMyImage smi in PList)
            {
                if (sname == smi.ShortName)
                {
                    lblCategory.Text = smi.Category;
                    lblShortName.Text = smi.ShortName;
                }
            }

        }

        private void btnShowImage_Click(object sender, EventArgs e)
        {
            string sname = cmbPictures.Text;
            foreach (SubjectMyImage smi in PList)
            {
                if (sname == smi.ShortName)
                {
                    pic1.Image = smi.GetBitmap();
                    lblWidth.Text = smi.GetImageSize().Width.ToString();
                    lblHeight.Text = smi.GetImageSize().Height.ToString();
                }
            }
        }

        private void btnProtectionProxy_Click(object sender, EventArgs e)
        {
            try
            {
                ProtectionProxy prp = new ProtectionProxy();
                bool res = prp.Authenticate("secret");
                string sql = "select ProductName from Products where " + "ProductId=10000";
                object obj = prp.GetSingleAnswer(sql);
                if (obj != null)
                    MessageBox.Show(obj.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
