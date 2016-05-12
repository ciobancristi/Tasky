﻿using System;
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
                adminPanelButton.Visible = false;
                panicButton.Visible = false;
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
            ProjectsForm projectsForm = new ProjectsForm();
            projectsForm.Show();
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
            AdminForm form = new AdminForm();
            form.Show();
        }

        private void timeCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TimeCheckForm();
            form.Show();
        }
    }
}
