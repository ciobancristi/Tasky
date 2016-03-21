using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminEmailForm admEmailForm = new adminEmailForm();
            admEmailForm.Show();
            //this.Close();
        }

        private void registerUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminNewUserRegistration admUserReg = new adminNewUserRegistration();
            admUserReg.Show();
            //this.Close();
        }

        private void homeCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
