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
using Tasky.Services.Models;
using Tasky.Services.Helpers;

namespace Tasky
{
    public partial class ClientsForm : Form
    {
        private IClientService _clientService;

        public ClientsForm()
        {
            _clientService = new ClientService();
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            var clients = _clientService.GetClients().ToList();
            var clientViewModels = new List<ClientViewModel>();
            foreach(var client in clients)
            {
                var projectNames = "";
                foreach(var project in client.Projects)
                {
                    projectNames += project.Name + " ";
                }
                clientViewModels.Add(new ClientViewModel
                {
                    ClientId = client.ClientId,
                    Name = client.Name,
                    Projects = projectNames
                });
            }
            //clientsDataGridView.DataSource = clientViewModels;
            //clientsDataGridView.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelNewClient.Visible = true;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var projectsForm = new AdminProjectsForm();
            this.Hide();
            projectsForm.Show();
            this.Close();
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
    }
}
