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
