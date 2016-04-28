using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tasky.Entities;
using Tasky.Services.Models;

namespace Tasky
{
    public partial class AdminProjectsForm : Form
    {
        private TaskyDBEntities _dbContext;
        public AdminProjectsForm()
        {
            InitializeComponent();
            _dbContext = new TaskyDBEntities();
            BindData();
        }

        private void BindData()
        {
            var projects = _dbContext.Projects.ToList();
            var projectViewModels = new List<ProjectViewModel>();
            foreach(var p in projects)
            {
                projectViewModels.Add(new ProjectViewModel
                {
                    Client = p.Client,
                    Created = p.Created,
                    HasFinished = p.HasFinished,
                    Name = p.Name,
                    ProjectId = p.ProjectId
                });
            }
            projectsDataGridView.DataSource = projectViewModels;
            projectsDataGridView.Columns[0].Visible = false;
        }

        private void addProjectButton_Click(object sender, EventArgs e)
        {
            var form = new AddProjectForm();
            form.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
