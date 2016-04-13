using System;
using System.Windows.Forms;
using Tasky.Services;

namespace Tasky
{
    public partial class UsersListForm : Form
    {
        private IUserService _userService;
        public UsersListForm()
        {
            InitializeComponent();
            _userService = new UserService();
            BindData();
        }

        private void BindData()
        {
            usersGridView.DataSource = _userService.GetAllUserDetails();
        }
    }
}
