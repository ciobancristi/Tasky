using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tasky.Services;

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
    }
}
