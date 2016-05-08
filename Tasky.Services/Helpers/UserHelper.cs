using System;
using System.Linq;
using Tasky.Entities;

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
        #endregion
    }
}
