using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tasky.Entities;
using Tasky.Services;
using Tasky.Services.Common;
using Tasky.Services.Models;
using Tasky.Services.Helpers;

namespace Tasky
{
    public partial class AddProjectForm : Form
    {
        public delegate void OnSaveEventHandler(object sender, EventArgs e);
        public event OnSaveEventHandler OnSaveEvent;

        private IUserService _userService;
        private IProjectService _projectService;
        private IClientService _clientService;
        private IMapper _mapper;
        private Project projectToEdit;

        public AddProjectForm()
        {
            InitializeComponent();
            _userService = new UserService();
            _projectService = new ProjectService();
            _clientService = new ClientService();
            _mapper = App.Mapper;

            BindData();
        }

        public AddProjectForm(Project project)
        {
            InitializeComponent();
            _userService = new UserService();
            _projectService = new ProjectService();
            _clientService = new ClientService();
            _mapper = App.Mapper;
            projectToEdit = project;

            BindData();
        }

        private void BindData()
        {
            BindProjectTaskData();
            BindProjectUserData();
            BindClients();
        }

        private void BindProjectUserData()
        {
            var projectUsers = new List<ProjectUserViewModel>();
            var users = _userService.GetAllUserDetails()
                   .Select(x => _mapper.Map<NameValueItem>(x))
                   .ToList();
            
            ((ListBox)userCheckedListBox).DataSource = projectUsers;
            ((ListBox)userCheckedListBox).DisplayMember = "Name";
            ((ListBox)userCheckedListBox).ValueMember = "Value";
        }

        private void BindProjectTaskData()
        {
            var tasks = _projectService.GetProjectTasks();
            ((ListBox)taskCheckedListBox).DataSource = tasks;
            ((ListBox)taskCheckedListBox).DisplayMember = "Name";
            ((ListBox)taskCheckedListBox).ValueMember = "ProjectTaskId";
        }

        private void BindClients()
        {
            var clients = _clientService.GetClients()
                            .Select(x => _mapper.Map<NameValueItem>(x))
                            .ToList();
            clientsComboBox.DataSource = clients;
            clientsComboBox.DisplayMember = "Name";
            clientsComboBox.ValueMember = "Value";
        }

        private void addProjectButton_Click(object sender, EventArgs e)
        {
            var projectName = projectNameTexBox.Text;
            NameValueItem selectedClient = (NameValueItem)clientsComboBox.SelectedItem;
            List<Guid> userIds = new List<Guid>();
            List<int> taskIds = new List<int>();

            foreach (NameValueItem user in userCheckedListBox.CheckedItems)
            {
                userIds.Add(new Guid(user.Value));
            }
            foreach (ProjectTask task in taskCheckedListBox.CheckedItems)
            {
                taskIds.Add(task.ProjectTaskId);
            }
            if (projectName.Length > 0 && userIds.Count > 0
                && taskIds.Count > 0 && clientsComboBox.Items.Count > 0)
            {
                if (projectToEdit != null)
                {
                    var newProject = new NewProjectModel
                    {
                        Name = projectName,
                        ClientId = int.Parse(selectedClient.Value),
                        TaskIds = taskIds,
                        UserIds = userIds
                    };
                    _projectService.AddProject(newProject);
                    MessageBox.Show("Project Saved Successfully");
                    OnSaveEvent.Invoke(this, e);
                    Close();
                }
                else
                {
                    var newProject = new NewProjectModel
                    {
                        Name = projectName,
                        ClientId = int.Parse(selectedClient.Value),
                        TaskIds = taskIds,
                        UserIds = userIds
                    };
                    //_projectService.EditProject(projectToEdit.ProjectId, newProject);
                    MessageBox.Show("Project Saved Successfully");
                    OnSaveEvent.Invoke(this, e);
                    Close();
                }
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

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            var projectsForm = new AdminProjectsForm();
            this.Hide();
            projectsForm.Show();
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var projectsForm = new AdminProjectsForm();
            this.Hide();
            projectsForm.Show();
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
