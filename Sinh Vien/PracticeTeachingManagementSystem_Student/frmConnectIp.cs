using System;
using System.Configuration;
using System.Windows.Forms;

namespace PracticeTeachingManagementSystem_Student
{
    public partial class frmConnectIp : Form
    {
        public frmConnectIp()
        {
            InitializeComponent();
        }


        private void bntConnect_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Server={0},1433;Database={1};uid={2};password={3};Trusted_Connection={4};MultipleActiveResultSets={5};Integrated Security= {6}", txtIp.Text, "PTMS", "sa", "123456", "True", "true", "false");
            try
            {
                //configHelper helper = new configHelper(connectionString);
                if (true)
                {
                    AppSetting setting = new AppSetting();
                    setting.SaveConnectionString("PracticeTeachingManagementSystem_Student.Properties.Settings.PTMSConnectionString1", connectionString);
                    MessageBox.Show("Lưu thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Application.Exit();// test nên comment
                    System.Diagnostics.Process.Start(Application.ExecutablePath); // test nên comment
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu không thành công");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["PracticeTeachingManagementSystem_Student.Properties.Settings.PTMSConnectionString1"].ToString();
            string a = conStr.Substring(7, conStr.IndexOf(",") - 7);
            MessageBox.Show(a, "Địa chỉ IP hiện tại của Server");
        }

        private void frmConnectIp_Load(object sender, EventArgs e)
        {

        }
    }
}
