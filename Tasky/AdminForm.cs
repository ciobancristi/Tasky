using System;
using System.Windows.Forms;
using Tasky.Services;
using Tasky.Services.Common;

namespace Tasky
{
    public partial class AdminForm : Form
    {
        private ReportsService _reportService;
        public AdminForm()
        {
            _reportService = new ReportsService();
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

        private void lastWeekButton_Click(object sender, System.EventArgs e)
        {
            var dayOfLastWeek = DateTime.Now.StartOfWeek(DayOfWeek.Monday).AddDays(-1);
            _reportService.GenerateWeeklyReports(dayOfLastWeek);
        }

        private void CurrentWeekReminder_Click(object sender, EventArgs e)
        {
            var today = DateTime.Now.Date;
            _reportService.GenerateWeeklyReports(today);
        }
    }
}
