using System;
using System.Linq;
using Tasky.Entities;
using Tasky.Services.Common;

namespace Tasky.Services.Helpers
{
    public static class UserHelper
    {
        private static User _currentUser;

        #region public members
        public static void SetUser(User currentUser)
        {
            if (currentUser == null)
                throw new ArgumentNullException();
            _currentUser = currentUser;
        }

        public static Guid GetUserId()
        {
            if (_currentUser == null)
                throw new MissingFieldException();
            return _currentUser.UserId;
        }

        public static void ResetCurrentUser()
        {
            _currentUser = null;
        }

        public static bool IsAdmin()
        {
            if (_currentUser == null)
                throw new MissingFieldException();
            var role = _currentUser.Roles.FirstOrDefault(r => r.Name == "Admin");
            return role != null;
        }

        public static string CurrentUserFullName
        {
            get
            {
                if (_currentUser != null)
                {
                    string fullName;
                    if (_currentUser.UserDetail != null)
                    {
                        fullName = _currentUser.UserDetail.FirstName + " " + _currentUser.UserDetail.LastName;
                        if (fullName.Length <= 1)
                        {
                            fullName = _currentUser.Name;
                        }
                    }
                    else
                    {
                        fullName = _currentUser.Name;
                    }
                    return fullName;
                }
                else
                    throw new MissingFieldException();
            }
        }

        public static UserDetail CurrentUserDetails
        {
            get
            {
                if (_currentUser != null)
                {
                    return _currentUser.UserDetail;
                }
                else
                    throw new MissingFieldException();
            }
        }
        #endregion
    }
}
