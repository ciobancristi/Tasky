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

 

        }

        private UserDetail UserDetails()
        {
            _userService = new UserService();
            UserDetail _currentUser = _userService.GetUserDetails();
            return _currentUser;
        }

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

        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
