using AutoMapper;
using System;
using System.Linq;
using System.Windows.Forms;
using Tasky.Services;
using Tasky.Services.Common;
using Tasky.Services.Helpers;
using Tasky.Services.Models;

namespace Tasky
{
    public partial class UserListForm : Form
    {
        private IUserService _userService;
        private IMapper _mapper;

        public UserListForm(bool isAddUserVisible)
        {
            InitializeComponent();
            _userService = new UserService();
            _mapper = App.Mapper;

            BindData();
            addUserButton.Visible = isAddUserVisible;
        }

        private void BindData()
        {
            var models = _userService.GetAllUserDetails()
                    .Select(x => _mapper.Map<UserDetailsViewModel>(x)).ToList();
            usersGridView.DataSource = models;
            //usersGridView.Columns[2].Visible = false;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            var form = new AdminNewUserRegistration();
            form.OnSaveEvent += new AdminNewUserRegistration.OnSaveEventHandler(HandleOnAddNewUserEvent);
            form.Show();
        }

        private void HandleOnAddNewUserEvent(object sender, EventArgs e)
        {
            BindData();
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
