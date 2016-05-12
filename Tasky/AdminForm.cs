using System.Windows.Forms;

namespace Tasky
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void emailToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AdminEmailForm admEmailForm = new AdminEmailForm();
            admEmailForm.Show();
        }

        private void projectsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AdminProjectsForm form = new AdminProjectsForm();
            form.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var form = new UserListForm(true);
            form.Show();
        }

        private void closeButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
