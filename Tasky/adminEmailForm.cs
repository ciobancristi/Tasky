using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tasky.Services;
using Tasky.Services.Helpers;

namespace Tasky
{
    public partial class AdminEmailForm : Form
    {
        private IValidationService _validationService;
        private List<string> destinationEmails;
        public AdminEmailForm()
        {
            InitializeComponent();
            destinationEmails = new List<string>();
            _validationService = new ValidationService();
        }

        //TODO: modify messageBox 
        private void sendButton_Click(object sender, EventArgs e)
        {
            if (AreValidFields())
            {
                MailHelper.SendMail(destinationEmails, subjectTextBox.Text, bodyTextBox.Text);
                MessageBox.Show("The mails were sent successfuly!");
                ResetFields();
            }
        }

        //TODO: refractor, add whitespace validation
        private bool AreValidFields()
        {
            var to = toTextBox.Text;
            var subject = subjectTextBox.Text;
            var body = bodyTextBox.Text;

            if (to.Length == 0 || subject.Length == 0 || body.Length == 0)
                return false;

            var destination = to.Split(',');
            destinationEmails.AddRange(destination);
            foreach (var dest in destinationEmails)
            {
                if (!_validationService.IsValidEmail(dest))
                    return false;
            }
            return true;
        }

        private void ResetFields()
        {
            toTextBox.Clear();
            subjectTextBox.Clear();
            bodyTextBox.Clear();
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

        private void button4_Click(object sender, EventArgs e)
        {
            var projectsForm = new AdminProjectsForm();
            this.Hide();
            projectsForm.Show();
            this.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            var clientForm = new ClientsForm();
            this.Hide();
            clientForm.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var log = new Login();
            this.Hide();
            log.Show();
            this.Close();
        }
    }
}
