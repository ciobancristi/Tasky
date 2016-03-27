using System;
using System.Collections.Generic;
using Tasky.Entities;

namespace Tasky.Services
{

    public interface IUserService
    {
    }
    public class UserService : BaseService, IUserService
    {
        private TaskyDBEntities _dbContext;

        public UserService()
        {
            _dbContext = new TaskyDBEntities();
        }

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
