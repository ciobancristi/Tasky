using System;
using System.Windows.Forms;
using Tasky.Services.Helpers;

namespace Tasky
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            if (!UserHelper.IsAdmin())
            {
                //adminPanelButton.Visible = false;
                //panicButton.Visible = false;
            }
            if (UserHelper.IsAdmin())
            {
                panelAdminHome.Visible = true;
                panelUserHome.Visible = false;
            }
            else
            {
                panelAdminHome.Visible = false;
                panelUserHome.Visible = true;
            }

        }

        private void panicButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserListForm usersListForm = new UserListForm(false);
            usersListForm.Show();
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserProfileForm userProfileForm = new UserProfileForm();
            userProfileForm.Show();
        }

        private void registerUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminNewUserRegistration admUserReg = new AdminNewUserRegistration();
            admUserReg.Show();
        }

        private void adminPanelButton_Click(object sender, EventArgs e)
        {

        }

        private void timeCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TimeCheckForm();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            var emailForm = new AdminEmailForm();
            this.Hide();
            emailForm.Show();
            this.Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            var usersForm = new UserListForm(UserHelper.IsAdmin());
            this.Hide();
            usersForm.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var clientForm = new ClientsForm();
            this.Hide();
            clientForm.Show();
            this.Close();
        }
    }
}
