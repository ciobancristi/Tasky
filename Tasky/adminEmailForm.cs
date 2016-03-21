using System;
using System.Windows.Forms;
using Tasky.Services;

namespace Tasky
{
    public partial class AdminEmailForm : Form
    {
        private IValidationService _validationService;
        public AdminEmailForm()
        {
            InitializeComponent();
            _validationService = new ValidationService();
        }

        //TODO: modify messageBox 
        private void sendButton_Click(object sender, EventArgs e)
        {
            if (AreValidFields())
            {
                MailHelper.SendMail(toTextBox.Text, subjectTextBox.Text, bodyTextBox.Text);
                MessageBox.Show("The mail was sent successfuly!");
                ResetFields();
            }
        }

        //TODO: refractor, add whitespace validation
        private bool AreValidFields()
        {
            var to = toTextBox.Text;
            var subject = subjectTextBox.Text;
            var body = bodyTextBox.Text;
            string[] fields = { to, subject, body };

            if (_validationService.IsEmptyValidation(fields))
            {
                MessageBox.Show("You cannot leave empty fields!");
                return false;
            }

            if (!_validationService.IsValidEmail(to))
            {
                MessageBox.Show("Invalid e-mail!");
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
