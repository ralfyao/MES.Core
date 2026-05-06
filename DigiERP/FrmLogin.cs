using DigiERP.Models;
using log4net;
using log4net.Config;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;

namespace DigiERP
{
    public partial class FrmLogin : Form
    {
        private static ILog logger = LogManager.GetLogger(typeof(FrmLogin));
        public FrmLogin()
        {
            InitializeComponent();
            XmlConfigurator.Configure(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + @"\log4net.config"));
            this.AcceptButton = button1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAccount.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AutheiticateController controller = new AutheiticateController();
                User user = new User();
                user.username = txtAccount.Text.Trim();
                user.password = txtPassword.Text.Trim();
                List<User> users = new List<User>();
                CommonRep<User> commonRep = controller.Login(user);
                if (commonRep.ErrorMessage != null && !string.IsNullOrEmpty(commonRep.ErrorMessage))
                {
                    MessageBox.Show(commonRep.ErrorMessage);
                }
                else
                {
                    this.Visible = false;
                    AppSession.User = commonRep.result;
                    FrmMain frmMain = new FrmMain();
                    frmMain.SetUser(AppSession.User);
                    frmMain.ShowDialog();
                    this.Dispose();
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
