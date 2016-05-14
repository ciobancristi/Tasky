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
            clientsDataGridView.DataSource = clientViewModels;
            clientsDataGridView.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
