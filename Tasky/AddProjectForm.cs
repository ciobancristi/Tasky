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
            label4.Text = UserHelper.CurrentUserFullName;
            label1.Text = "Add project";
            label2.Visible = false;
            checkBox1.Visible = false;
        }

        public AddProjectForm(int projectId)
        {
            InitializeComponent();
            _userService = new UserService();
            _projectService = new ProjectService();
            _clientService = new ClientService();
            _mapper = App.Mapper;
            projectToEdit = _projectService.GetProject(projectId);

            BindData();
            label4.Text = UserHelper.CurrentUserFullName;
            label1.Text = "Edit project";
            label2.Visible = true;
            checkBox1.Visible = true;
            MarkSelectedUsers();
            MarkSelectedTasks();
            clientsComboBox.SelectedIndex = clientsComboBox.FindStringExact(projectToEdit.Client.Name);
            projectNameTexBox.Text = projectToEdit.Name;
            checkBox1.Checked = projectToEdit.HasFinished;
        }

        private void MarkSelectedTasks()
        {
            foreach (var u in projectToEdit.ProjectTasks)
            {
                for (int i = 0; i < taskCheckedListBox.Items.Count; i++)
                {
                    NameValueItem item = (NameValueItem)taskCheckedListBox.Items[i];
                    if (item.Value == u.ProjectTaskId.ToString())
                    {
                        taskCheckedListBox.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void MarkSelectedUsers()
        {
            foreach (var u in projectToEdit.Users)
            {
                for (int i = 0; i < userCheckedListBox.Items.Count; i++)
                {
                    NameValueItem item = (NameValueItem)userCheckedListBox.Items[i];
                    if (item.Value == u.UserId.ToString())
                    {
                        userCheckedListBox.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void BindData()
        {
            BindProjectTaskData();
            BindProjectUserData();
            BindClients();
        }

        private void BindProjectUserData()
        {
            var users = _userService.GetAllUserDetails()
                   .Select(x => _mapper.Map<NameValueItem>(x))
                   .ToList();

            ((ListBox)userCheckedListBox).DataSource = users;
            ((ListBox)userCheckedListBox).DisplayMember = "Name";
            ((ListBox)userCheckedListBox).ValueMember = "Value";
        }

        private void BindProjectTaskData()
        {
            var tasks = _projectService.GetProjectTasks()
                    .Select(x => _mapper.Map<NameValueItem>(x))
                   .ToList();
            ((ListBox)taskCheckedListBox).DataSource = tasks;
            ((ListBox)taskCheckedListBox).DisplayMember = "Name";
            ((ListBox)taskCheckedListBox).ValueMember = "Value";
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

        //ADD validation
        private void addProjectButton_Click(object sender, EventArgs e)
        {
            if (projectNameTexBox.Text == "") { label3.Visible = true; }
            else if (clientsComboBox.SelectedItem.ToString() == "") { label5.Visible = true; }
            else if (taskCheckedListBox.SelectedItems.Count == 0) { label6.Visible = true; }
            else if (userCheckedListBox.SelectedItems.Count == 0) { label7.Visible = true; }
            else {
                var projectName = projectNameTexBox.Text;
                NameValueItem selectedClient = (NameValueItem)clientsComboBox.SelectedItem;
                List<Guid> userIds = new List<Guid>();
                List<int> taskIds = new List<int>();

                foreach (NameValueItem user in userCheckedListBox.CheckedItems)
                {
                    userIds.Add(new Guid(user.Value));
                }
                foreach (NameValueItem task in taskCheckedListBox.CheckedItems)
                {
                    taskIds.Add(int.Parse(task.Value));
                }
                if (projectName.Length > 0 && userIds.Count > 0
                    && taskIds.Count > 0 && clientsComboBox.Items.Count > 0)
                {
                    if (projectToEdit == null)
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

                        var projectsForm = new AdminProjectsForm();
                        Hide();
                        projectsForm.Show();
                        Close();

                    }
                    else
                    {
                        var editedProject = new EditProjectModel
                        {
                            Name = projectName,
                            ClientId = int.Parse(selectedClient.Value),
                            TaskIds = taskIds,
                            UserIds = userIds,
                            HasFinished = checkBox1.Checked
                        };
                        _projectService.EditProject(projectToEdit.ProjectId, editedProject);
                        MessageBox.Show("Project Saved Successfully");
                        var projectsForm = new AdminProjectsForm();
                        Hide();
                        projectsForm.Show();
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("All fields are required");
                }
            }
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
