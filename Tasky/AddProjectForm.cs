using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tasky.Entities;
using Tasky.Services;
using Tasky.Services.Models;

namespace Tasky
{
    public partial class AddProjectForm : Form
    {
        private TaskyDBEntities _dbContext;
        private IProjectService _projectService;
        public AddProjectForm()
        {
            InitializeComponent();
            _dbContext = new TaskyDBEntities();
            _projectService = new ProjectService();

            BindData();
        }

        private void BindData()
        {
            BindProjectTaskData();
            BindProjectUserData();
        }

        private void BindProjectUserData()
        {
            var projectUsers = new List<ProjectUserViewModel>();
            var users = _dbContext.UserDetails.ToList();
            foreach (var user in users)
            {
                projectUsers.Add(new ProjectUserViewModel
                {
                    UserId = user.UserId,
                    FullName = user.FirstName + ' ' + user.LastName
                });
            }
            ((ListBox)userCheckedListBox).DataSource = projectUsers;
            ((ListBox)userCheckedListBox).DisplayMember = "FullName";
            ((ListBox)userCheckedListBox).ValueMember = "UserId";
        }

        private void BindProjectTaskData()
        {
            var tasks = _dbContext.ProjectTasks.ToList();
            ((ListBox)taskCheckedListBox).DataSource = tasks;
            ((ListBox)taskCheckedListBox).DisplayMember = "Name";
            ((ListBox)taskCheckedListBox).ValueMember = "ProjectTaskId";
        }

        private void addProjectButton_Click(object sender, EventArgs e)
        {
            string projectName = projectNameTexBox.Text,
                   clientName = clientTextBox.Text;
            List<Guid> userIds = new List<Guid>();
            List<int> taskIds = new List<int>();

            foreach (ProjectUserViewModel user in userCheckedListBox.SelectedItems)
            {
                userIds.Add(user.UserId);
            }
            foreach (ProjectTask task in taskCheckedListBox.SelectedItems)
            {
                taskIds.Add(task.ProjectTaskId);
            }
            if (projectName.Length > 0 && clientName.Length > 0
                && userIds.Count > 0 && taskIds.Count > 0)
            {
                _projectService
                    .AddProject(projectName, clientName, userIds, taskIds);
                MessageBox.Show("Project Saved Successfully");
            }
            else
            {
                MessageBox.Show("All fields are required");
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
