using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tasky.Services;
using Tasky.Services.Common;
using Tasky.Services.Helpers;
using Tasky.Services.Models;

namespace Tasky
{
    public partial class AddEditClient : Form
    {
        private IClientService _clientService;
        private IProjectService _projectService;
        private IMapper _mapper;
        public AddEditClient()
        {
            _clientService = new ClientService();
            _projectService = new ProjectService();
            _mapper = App.Mapper;
            InitializeComponent();
            BindProjects();
        }

        private void BindProjects()
        {
            var projects = _projectService.GetActiveProjects(UserHelper.GetUserId())
                .Select(x => _mapper.Map<NameValueItem>(x))
                .ToList();

            ((ListBox)projectCheckedListBox).DataSource = projects;
            ((ListBox)projectCheckedListBox).DisplayMember = "Name";
            ((ListBox)projectCheckedListBox).ValueMember = "Value";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = clientNameTextBox.Text;
            var projectIds = new List<int>();
            foreach(NameValueItem item in projectCheckedListBox.CheckedItems)
            {
                projectIds.Add(int.Parse(item.Value));
            }
            if(name.Length > 0 && projectIds.Count > 0)
            {
                _clientService.AddClient(name, projectIds);
            }else
            {
                MessageBox.Show("All fields are required");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new AddProjectForm();
            form.OnSaveEvent += new AddProjectForm.OnSaveEventHandler(HandleOnAddNewProjectEvent);
            form.Show();
        }

        private void HandleOnAddNewProjectEvent(object sender, EventArgs e)
        {
            BindProjects();
        }
    }
}
