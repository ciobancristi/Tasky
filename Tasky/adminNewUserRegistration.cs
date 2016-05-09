﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Tasky.Entities;
using Tasky.Services;

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
    }
}
