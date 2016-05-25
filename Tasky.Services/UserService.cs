using System;
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
        IEnumerable<string> GetRoles();
        IEnumerable<string> GetPositions();
        void RegisterUser(User currentUser, UserDetail userDetail, Role rol, Position pos);
        int GetNumberOfEmployees();
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
            var _currentUser = _dbContext.UserDetails.FirstOrDefault(u => u.UserId == currentUser);
            return _currentUser;
        }
        public IEnumerable<string> GetRoles()
        {
            var roles = _dbContext.Roles.Select(m => m.Name);
            return roles;
        }
        public IEnumerable<string> GetPositions()
        {
            var positions = _dbContext.Positions.Select(m => m.Name);
            return positions;
        }
        public User GetUser()
        {
            var currentUser = UserHelper.GetUserId();
            var _currentUser = _dbContext.Users.FirstOrDefault(u => u.UserId == currentUser);
            return _currentUser;
        }
        public void PostUser(User currentUser)
        {
            var olduser = GetUser();
            _dbContext.Entry(olduser).CurrentValues.SetValues(currentUser);
            _dbContext.SaveChanges();
        }
        public void RegisterUser(User currentUser, UserDetail userDetail, Role role, Position pos)
        {
            var selectedRole = _dbContext.Roles.FirstOrDefault(m => m.RoleId == role.RoleId);
            currentUser.Roles.Add(selectedRole);
            _dbContext.Users.Add(currentUser);
            var position = _dbContext.Positions.FirstOrDefault(m => m.Name == pos.Name);
            userDetail.PositionId = position.PositionId;
            userDetail.UserId = currentUser.UserId;
            _dbContext.UserDetails.Add(userDetail);
            _dbContext.SaveChanges();
        }
        public void PostUserDetails(UserDetail currentUser)
        {
            var olduser = GetUserDetails();
            _dbContext.Entry(olduser).CurrentValues.SetValues(currentUser);
            _dbContext.SaveChanges();
        }
        public List<UserDetail> GetAllUserDetails()
        {
            return _dbContext.UserDetails.ToList();
        }

        public int GetNumberOfEmployees()
        {
            return _dbContext.Users.Count();
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
