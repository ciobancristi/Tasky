using System;
using System.Linq;
using Tasky.Entities;

namespace Tasky.Services
{
    public interface IAuthenticationService
    {
        bool CheckCredentials(string userName, string password);
    }
    public class AuthenticationService : BaseService, IAuthenticationService
    {
        private TaskyDBEntities _dbContext;

        public AuthenticationService()
        {
            _dbContext = new TaskyDBEntities();
        }

        #region IAuthenticationService
        public bool CheckCredentials(string userName, string password)
        {
            IQueryable<User> users = _dbContext.Users;
            return users.FirstOrDefault(u => u.Name == userName && u.Password == password) != null;
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
