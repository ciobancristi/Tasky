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
        }

        private void panicButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersListForm usersListForm = new UsersListForm();
            usersListForm.Show();
            //this.Close();
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectsForm projectsForm = new ProjectsForm();
            projectsForm.Show();
            //this.Close();
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserProfileForm userProfileForm = new UserProfileForm();
            userProfileForm.Show();
            //this.Close();
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminEmailForm admEmailForm = new AdminEmailForm();
            admEmailForm.Show();
            //this.Close();
        }

        private void registerUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminNewUserRegistration admUserReg = new AdminNewUserRegistration();
            admUserReg.Show();
            //this.Close();
        }

    }
}
