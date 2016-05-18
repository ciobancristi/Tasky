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
            label4.Text = UserHelper.CurrentUserFullName;
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

        private void deleteProjectButton_Click(object sender, EventArgs e)
        {
            var project = projectsDataGridView.SelectedRows;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            var usersForm = new UserListForm(UserHelper.IsAdmin());
            this.Hide();
            usersForm.Show();
            this.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            var logHrs = new TimeCheckForm();
            this.Hide();
            logHrs.Show();
            this.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            var clientForm = new ClientsForm();
            this.Hide();
            clientForm.Show();
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            var emailForm = new AdminEmailForm();
            this.Hide();
            emailForm.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var userForm = new UserProfileForm();
            this.Hide();
            userForm.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var form = new HomeForm();
            Hide();
            form.Show();
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserHelper.ResetCurrentUser();
            var form = new Login();
            Hide();
            form.Show();
            Close();
        }
    }
}
