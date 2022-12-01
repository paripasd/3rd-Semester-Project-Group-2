using ClientApp.RestClientLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientApp.ModelLayer;

namespace ClientApp.UILayer
{
    public partial class LoginForm : Form
    {
        private ApiLoginDataAccess loginApi;
        public LoginForm()
        {
            InitializeComponent();
            loginApi = new ApiLoginDataAccess("https://localhost:7023/ap1/v1/Login");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginButtonValidate();
        }

        #region Methods

        public void LoginButtonValidate()
        {
            Login login = new Login(textBoxUserName.Text, textBoxPassword.Text);
            if (loginApi.ValidateLogin(login) == true)
            {
                this.Hide();
                MainForm main = new MainForm();
                main.ShowDialog();
            }
        }
        #endregion
    }
}
