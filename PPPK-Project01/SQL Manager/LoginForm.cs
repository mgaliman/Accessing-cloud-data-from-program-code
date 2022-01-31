using SQL_Manager.Dal;
using System;
using System.Windows.Forms;

namespace SQL_Manager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                RepositoryFactory.GetRepository().LogIn(TbServer.Text.Trim(),
                        TbUsername.Text.Trim(),
                        TbPassword.Text.Trim());
                new MainForm().Show();
                Hide();
            }
            catch (Exception ex)
            {
                LbError.Text = ex.Message;
            }
        }
    }
}
