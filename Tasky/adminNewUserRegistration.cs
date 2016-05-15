using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Tasky.Entities;
using Tasky.Services;
using Tasky.Services.Helpers;

namespace Tasky
{
    public partial class AdminNewUserRegistration : Form
    {
        public delegate void OnSaveEventHandler(object sender, EventArgs e);
        public event OnSaveEventHandler OnSaveEvent;

        public AdminNewUserRegistration()
        {
            InitializeComponent();
            Position _userPosition = new Position();
            UserService user = new UserService();
            var roles = user.GetRoles();
            roleComboBox.Items.AddRange(roles.ToArray());
            var positions = user.GetPositions();
            positionComboBox.Items.AddRange(positions.ToArray());
        }

        private void registerUserButton_Click(object sender, EventArgs e)
        {
            UserService user = new UserService();
            UserDetail _userDetails = new UserDetail();
            User _user = new User();
            Role _userRole = new Role();
            Position _userPosition = new Position();
            _user.UserId = Guid.NewGuid();
            _user.Name = usernameTextBox.Text;
            _user.Password = GeneratePassword();

            _userDetails.Email = emailTextBox.Text;

            _userRole.Name = roleComboBox.SelectedItem.ToString();
            _userPosition.Name = positionComboBox.SelectedItem.ToString();

            user.RegisterUser(_user, _userDetails, _userRole, _userPosition);

            var subject = "Welcome to Tasky";
            var body = "Welcome " + usernameTextBox.Text + ",<br>You have been registered by an admin on Tasky." +
                "Your username is <b>" + usernameTextBox.Text + "</b> and your password is <b>" +
             _user.Password + "</b><br> Have a good day";
            MailHelper.SendMail(_userDetails.Email, subject, body);
            MessageBox.Show("User Registered Succesfully");
            // invoke OnSaveEvent to notify the parent that a new user has been added
            OnSaveEvent?.Invoke(this, e);
            Close();
        }

        private static string GeneratePassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var length = 10;
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var projectsForm = new AdminProjectsForm();
            this.Hide();
            projectsForm.Show();
            this.Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            var usersForm = new UserListForm(UserHelper.IsAdmin());
            this.Hide();
            usersForm.Show();
            this.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            var logHrs = new TimeCheckForm();
            this.Hide();
            logHrs.Show();
            this.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            var clientForm = new ClientsForm();
            this.Hide();
            clientForm.Show();
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            var emailForm = new AdminEmailForm();
            this.Hide();
            emailForm.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var usersForm = new UserListForm(UserHelper.IsAdmin());
            this.Hide();
            usersForm.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var userForm = new UserProfileForm();
            this.Hide();
            userForm.Show();
            this.Close();
        }
    }
}
