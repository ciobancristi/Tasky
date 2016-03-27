using System;
using System.Windows.Forms;
using Tasky.Services;

namespace Tasky
{
    public partial class Login : Form
    {
        private IAuthenticationService _authenticationService;
        private IValidationService _validationService;
        public Login()
        {
            InitializeComponent();
            _authenticationService = new AuthenticationService();
            _validationService = new ValidationService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userName = UsernameTextbox.Text;
            var password = PasswordTextbox.Text;
            string[] fields = {userName, password};
            if (!_validationService.IsEmptyValidation(fields))
            {
                if (_authenticationService.CheckCredentials(userName, password))
                {
                    var homeForm = new HomeForm();
                    homeForm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("User/Password incorrect!");
                }
            }
            else
            {
                MessageBox.Show("You must provide a user and a password!");
            }
        }

        private void ExitLoginButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
