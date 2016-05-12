using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tasky.Entities;
using Tasky.Services;
using Tasky.Services.Common;
using Tasky.Services.Helpers;
using Tasky.Services.Models;

namespace Tasky
{
    public partial class AdminProjectsForm : Form
    {
        private IProjectService _projectService;
        private IMapper _mapper;
        public AdminProjectsForm()
        {
            _projectService = new ProjectService();
            _mapper = App.Mapper;
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            var projects = _projectService
                            .GetActiveProjects(UserHelper.GetUserId())
                            .Select(x => _mapper.Map<ProjectViewModel>(x))
                            .ToList();
            
            projectsDataGridView.DataSource = projects;
            projectsDataGridView.Columns[0].Visible = false;
        }

        private void addProjectButton_Click(object sender, EventArgs e)
        {
            var form = new AddProjectForm();
            form.OnSaveEvent += new AddProjectForm.OnSaveEventHandler(HandleOnAddNewProjectEvent);
            form.Show();
        }

        private void HandleOnAddNewProjectEvent(object sender, EventArgs e)
        {
            BindData();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
