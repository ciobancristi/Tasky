using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tasky.Entities;
using Tasky.Services;
using Tasky.Services.Helpers;

namespace Tasky
{
    public partial class UserProfileForm : Form
    {
       private IUserService  _userService;

        public UserProfileForm()
        {
            InitializeComponent();
            UserDetail _currentUser = UserDetails();
                emailTextBox.Text = _currentUser.Email;
            if (_currentUser.FirstName != null)
                firstNameTextBox.Text = _currentUser.FirstName;
            if (_currentUser.LastName != null)
                lastNameTextBox.Text = _currentUser.LastName;
            if (_currentUser.BirthDate != null)
                birthdayDatePicker.Value = (DateTime)_currentUser.BirthDate;
            if (_currentUser.Phone != null)
                phoneTextBox.Text = _currentUser.Phone;

            label4.Text = UserHelper.CurrentUserFullName;

        }
        
        private UserDetail UserDetails()
        {
            _userService = new UserService();
            // foloseste UserHelper.CurrentUserDetails
            UserDetail _currentUser = _userService.GetUserDetails();
            return _currentUser;
        }

        // TODO: add validation
        private void submitDataButton_Click(object sender, EventArgs e)
        {
            UserDetail _currentUser = UserDetails();
            if (emailTextBox.Text !=null)
               _currentUser.Email = emailTextBox.Text;
            if (firstNameTextBox.Text != null)
              _currentUser.FirstName= firstNameTextBox.Text;
            if ( lastNameTextBox.Text != null)
                _currentUser.LastName= lastNameTextBox.Text;
            if (birthdayDatePicker.Value != null)
               _currentUser.BirthDate = birthdayDatePicker.Value;
            if (phoneTextBox.Text != null)
               _currentUser.Phone= phoneTextBox.Text;
            _userService.PostUserDetails(_currentUser);
        }

        //TODO: add validation
        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            _userService = new UserService();
            User _currentUser = _userService.GetUser();
            if (_currentUser.Password == oldPasswordTextBox.Text)
                _currentUser.Password = newPasswordTextBox.Text;
            _userService.PostUser(_currentUser);

        }

        private void changePasswordLabel_Click(object sender, EventArgs e)
        {
            panelChangePass.Visible = true;
            panelUpdateInfo.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
            panelUpdateInfo.Visible = true;
            panelChangePass.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var usersForm = new UserListForm(UserHelper.IsAdmin());
            this.Hide();
            usersForm.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var logHrs = new TimeCheckForm();
            this.Hide();
            logHrs.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var projectsForm = new AdminProjectsForm();
            this.Hide();
            projectsForm.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var clientForm = new ClientsForm();
            this.Hide();
            clientForm.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var emailForm = new AdminEmailForm();
            this.Hide();
            emailForm.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var userForm = new UserProfileForm();
            this.Hide();
            userForm.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserHelper.ResetCurrentUser();
            var form = new Login();
            Hide();
            form.Show();
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var form = new HomeForm();
            Hide();
            form.Show();
            Close();
        }
    }
}
