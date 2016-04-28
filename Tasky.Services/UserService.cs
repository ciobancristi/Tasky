using System.Collections.Generic;
using System.Linq;
using Tasky.Entities;
using Tasky.Services.Helpers;

namespace Tasky.Services
{

    public interface IUserService
    {
        List<UserDetail> GetAllUserDetails();
        UserDetail GetUserDetails();
        void PostUserDetails(UserDetail currentUser);
        User GetUser();
        void PostUser(User currentUser);
    }
    public class UserService : BaseService, IUserService
    {
        private TaskyDBEntities _dbContext;

        public UserService()
        {
            _dbContext = new TaskyDBEntities();
        }
        
        #region IUserService

        public UserDetail GetUserDetails()
        {
            var currentUser = UserHelper.GetUserId();
            IQueryable<UserDetail> user = _dbContext.UserDetails;
            var _currentUser = user.FirstOrDefault(u => u.UserId == currentUser);
            return  _currentUser;
        }
        public User GetUser()
        {
            var currentUser = UserHelper.GetUserId();
            IQueryable<User> user = _dbContext.Users;
            var _currentUser = user.FirstOrDefault(u => u.UserId == currentUser);
            return _currentUser;
        }
        public void PostUser(User currentUser)
        {
            var olduser = GetUser();
            _dbContext.Entry(olduser).CurrentValues.SetValues(currentUser);
            _dbContext.SaveChanges();
        }
        public void PostUserDetails(UserDetail currentUser)
        { var olduser=GetUserDetails();
            _dbContext.Entry(olduser).CurrentValues.SetValues(currentUser);
            _dbContext.SaveChanges();
        }

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
