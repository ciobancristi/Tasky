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
        public UserListForm()
        {
            InitializeComponent();
            
        }
        public UserListForm(bool isAddUserVisible)
        {
            InitializeComponent();
            _userService = new UserService();
            _mapper = App.Mapper;

            BindData();
            addUserButton.Visible = isAddUserVisible;
            button4.Visible = isAddUserVisible;
            label4.Text = UserHelper.CurrentUserFullName;
            HideButtons();
        }

        private void HideButtons()
        {

            if (!UserHelper.IsAdmin())
            {
                button1.Visible = false;
                button6.Visible = false;
                button5.Visible = false;
                button4.Visible = false;
                addUserButton.Visible = false;
            }
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

        private void button8_Click(object sender, EventArgs e)
        {
            var logHrs = new TimeCheckForm();
            this.Hide();
            logHrs.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var projectsForm = new AdminProjectsForm();
            this.Hide();
            projectsForm.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var clientForm = new ClientsForm();
            this.Hide();
            clientForm.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var emailForm = new AdminEmailForm();
            this.Hide();
            emailForm.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserHelper.ResetCurrentUser();
            var login = new Login();
            this.Hide();
            login.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var userForm = new UserProfileForm();
            this.Hide();
            userForm.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var form = new HomeForm();
            Hide();
            form.Show();
            Close();
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {

        }
    }
}
