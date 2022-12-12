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
            loginApi = new ApiLoginDataAccess("https://localhost:7023/api/v1/Login");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            /*MainForm main = new MainForm(true);
            main.ShowDialog();*/
            LoginButtonValidate();
        }

        #region Methods
        //decides which view to show: admin or non admin
        public void LoginButtonValidate()
        {
            ModelLayer.Login login = new ModelLayer.Login(textBoxUserName.Text, textBoxPassword.Text);
            if (ValidateLogin(login) == true)
            {
                bool adminRights = GetFullLoginObject(login).AdminRights;
                if (adminRights == true)
                {
                    this.Hide();
                    MainForm main = new MainForm(true);
                    main.ShowDialog();
                }
                else if (adminRights == false)
                {
                    this.Hide();
                    MainForm main = new MainForm(false);
                    main.ShowDialog();
                } 
            }
        }
        //check if username and password combo is valid
        public bool ValidateLogin(Login incomingLogin)
        {
            IEnumerable<Login> logins = loginApi.GetAllLogins();
            foreach (Login login in logins)
            {
                bool IsValidUserName = incomingLogin.UserName.Equals(login.UserName);
                bool IsValidPassword = Login.ValidatePassword(incomingLogin.Password, login.Password);
                if (IsValidUserName == true && IsValidPassword == true)
                {
                    return true;
                }
            }
            return false;
        }
        //get the admin rights info with the full object
        public Login GetFullLoginObject(Login incomingLogin)
        {
            IEnumerable<Login> logins = loginApi.GetAllLogins();
            Login fullLogin = new Login();
            foreach (Login login in logins)
            {
                if (incomingLogin.UserName.Equals(login.UserName) && Login.ValidatePassword(incomingLogin.Password, login.Password) == true)
                {
                    incomingLogin.AdminRights = login.AdminRights;
                    fullLogin.UserName = incomingLogin.UserName;
                    fullLogin.Password = incomingLogin.Password;
                    fullLogin.AdminRights = incomingLogin.AdminRights;
                }
            }
            return incomingLogin;
        }
        #endregion
    }
}
