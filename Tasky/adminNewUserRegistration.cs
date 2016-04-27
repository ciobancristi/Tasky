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

namespace Tasky
{
    public partial class AdminNewUserRegistration : Form
    {

        public AdminNewUserRegistration()
        {
            InitializeComponent();
        }

        private void registerUserButton_Click(object sender, EventArgs e)
        {
           
            UserDetail _userDetails = new UserDetail();
            User _user = new User();
            Position _userPosition = new Position();
            _user.UserId = Guid.NewGuid();
            _user.Name = usernameTextBox.Text;
            _userDetails.Email = emailTextBox.Text;
            _user.Password=GeneratePassword();
            //var subject = "Welcome to Tasky";
            //var body = "Welcome " + usernameTextBox.Text + ",<br>You have been registered by an admin on Tasky." +
            //    +"Your username is <b>" + usernameTextBox.Text + "</b> and your password is <b>" + _user.Password+"</b><br> Have a good day";
            //MailHelper.SendMail(emailTextBox.Text, subject, body);
            

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
            var subject = "Welcome to Tasky";
            var body = "Welcome " + usernameTextBox.Text + ",<br>You have been registered by an admin on Tasky." + "Your username is <b>" + usernameTextBox.Text + "</b> and your password is <b>" + GeneratePassword() + "</b><br> Have a good day";
            MailHelper.SendMail("spamsimulator2015@gmail.com", subject, body);
            MessageBox.Show("Sent");
        }
    }
}
