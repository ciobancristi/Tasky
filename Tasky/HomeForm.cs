using AutoMapper;
using System;
using System.Linq;
using System.Windows.Forms;
using Tasky.Services;
using Tasky.Services.Common;
using Tasky.Services.Helpers;
using Tasky.Services.Models;

namespace Tasky
{
    public partial class HomeForm : Form
    {
        private IUserService _userService;
        private IClientService _clientService;
        private IProjectService _projectService;
        private ITaskService _taskService;
        private IMapper _mapper;

        public HomeForm()
        {
            InitializeComponent();
            _userService = new UserService();
            _clientService = new ClientService();
            _projectService = new ProjectService();
            _taskService = new TaskService();
            _mapper = App.Mapper;

            if (UserHelper.IsAdmin())
            {
                panelAdminHome.Visible = true;
                panelUserHome.Visible = false;
                //dataGridView1.Visible = false;
            }
            else
            {
                panelAdminHome.Visible = false;
                panelUserHome.Visible = true;
                BindTasks();
            }

            label4.Text = UserHelper.CurrentUserFullName;
            label1.Text = "Number of Employees : " + _userService.GetNumberOfEmployees();
            label5.Text = "Number of Clients: " + _clientService.GetNumberOfClients();
            label6.Text = "Number of Projects: " + _projectService.GetNumberOfProjects();
            label7.Text = "Number of Active Projects: " + _projectService.GetNumberOfActiveProjects();
            BindTasks();
            HideButtons();

        }

        private void BindTasks()
        {
            var tasks = _taskService.GetTasks(DateTime.Now)
                    .Select(x => _mapper.Map<TaskViewModel>(x))
                    .ToList();
            dataGridView1.DataSource = tasks;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Visible = true;
        }

        private void HideButtons()
        {

            if (!UserHelper.IsAdmin())
            {
                button4.Visible = false;
                button6.Visible = false;
                button5.Visible = false;
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserHelper.ResetCurrentUser();
            var form = new Login();
            Hide();
            form.Show();
            Close();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var userForm = new UserProfileForm();
            this.Hide();
            userForm.Show();
            this.Close();
        }
    }
}
