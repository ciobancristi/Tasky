using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasky.Entities;

namespace Tasky.Services
{
    public interface IClientService
    {
        List<Client> GetClients();
        Client GetClient(int clientId);
        void EditClient(int clientId, Client editedClient);
        void DeleteClient(int clientId);
        void AddClient(string name, List<int> projectIds);
        int GetNumberOfClients();
    }

    public class ClientService : BaseService, IClientService
    {
        private TaskyDBEntities _dbContext;

        public ClientService()
        {
            _dbContext = new TaskyDBEntities();
        }

        #region IClientService
        public List<Client> GetClients()
        {
            var clients = _dbContext.Clients.ToList();

            return clients;
        }

        public Client GetClient(int clientId)
        {
            if (clientId < 0)
                throw new ArgumentOutOfRangeException();

            var client = _dbContext.Clients.FirstOrDefault(c => c.ClientId == clientId);

            return client;
        }

        public void EditClient(int clientId, Client editedClient)
        {
            if (clientId < 0)
                throw new ArgumentOutOfRangeException();
            if (editedClient == null)
                throw new ArgumentNullException();

            var client = _dbContext.Clients.FirstOrDefault(x => x.ClientId == clientId);
            if (client != null)
            {
                client.Name = editedClient.Name;
                client.Projects = editedClient.Projects;
                _dbContext.SaveChanges();
            }
        }

        public void DeleteClient(int clientId)
        {
            if (clientId < 0)
                throw new ArgumentOutOfRangeException();

            var client = _dbContext.Clients.FirstOrDefault(x => x.ClientId == clientId);
            if (client != null)
            {
                _dbContext.Clients.Remove(client);
                _dbContext.SaveChanges();
            }
        }

        public void AddClient(string name, List<int> projectIds)
        {
            if (name.Length == 0 || projectIds.Count <= 0)
                throw new ArgumentException();

            var projects = GetProjectsByIds(projectIds);
            var client = new Client
            {
                Name = name,
                Projects = projects
            };
            _dbContext.Clients.Add(client);
            _dbContext.SaveChanges();
        }

        public int GetNumberOfClients()
        {
            return _dbContext.Clients.Count();
        }
        #endregion

        #region private members
        private List<Project> GetProjectsByIds(List<int> projectIds)
        {
            var projects = new List<Project>();
            foreach(var id in projectIds)
            {
                var project = _dbContext.Projects.FirstOrDefault(x => x.ProjectId == id);
                if (project != null)
                    projects.Add(project);
            }
            return projects;
        }
        #endregion

        #region IDisposable
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_dbContext != null)
                {
                    _dbContext.Dispose();
                    _dbContext = null;
                }
            }
        }
        #endregion
    }


}
