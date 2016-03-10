using System;
using System.Windows.Forms;
using Tasky.Entities;
using Tasky.Services;

namespace Tasky
{
    public partial class Login : Form
    {
        private IAuthenticationService _authenticationService;
        public Login()
        {
            InitializeComponent();
            _authenticationService = new AuthenticationService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userName = UsernameTextbox.Text;
            var password = PasswordTextbox.Text;

            if(_authenticationService.CheckCredentials(userName, password)){
                var homeForm = new HomeForm();
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User/Password incorrect");
            }
        }

        private void ExitLoginButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
