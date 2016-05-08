using System;
using System.Windows.Forms;
using Tasky.Services;

namespace Tasky
{
    public partial class UserListForm : Form
    {
        private IUserService _userService;
        public UserListForm()
        {
            InitializeComponent();
            _userService = new UserService();
            BindData();
        }

        private void BindData()
        {
            usersGridView.DataSource = _userService.GetAllUserDetails();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            var form = new AdminNewUserRegistration();
            form.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {

        }
    }
}
