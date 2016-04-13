using System;
using System.Collections.Generic;
using System.Linq;
using Tasky.Entities;

namespace Tasky.Services
{

    public interface IUserService
    {
        List<UserDetail> GetAllUserDetails();
    }
    public class UserService : BaseService, IUserService
    {
        private TaskyDBEntities _dbContext;

        public UserService()
        {
            _dbContext = new TaskyDBEntities();
        }

        #region IUserService
        public List<UserDetail> GetAllUserDetails()
        {
            return _dbContext.UserDetails.ToList();
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
