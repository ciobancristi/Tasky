using AutoMapper;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Tasky.Services;
using Tasky.Services.Common;
using Tasky.Services.Models;

namespace Tasky
{
    public partial class TimeCheckForm : Form
    {
        private ITaskService _taskService;
        private readonly IMapper _mapper;

        public TimeCheckForm()
        {
            _taskService = new TaskService();
            _mapper = App.Mapper;

            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            BindTasks();
            UpdateTitle();

        }

        private void UpdateTitle()
        {
            var displayedDate = dateTimePicker.Value.ToString("dddd, dd MMMM, yyyy");
            titleLabel.Text += displayedDate;
        }

        private void BindTasks()
        {
            //var date = dateTimePicker.Value.Date;
            //var tasks = _taskService.GetTasks(date)
            //            .Select(x => _mapper.Map<TaskViewModel>(x))
            //            .ToList();
            //if (tasks.Count > 0)
            //{
            //    activitiesDataGridView.DataSource = tasks;
            //    activitiesDataGridView.Columns[0].Visible = false;
            //}
            //else
            //{
            //    noActivityLabel.Visible = true;
            //}
        }

        private void dateTimePicker_ValueChanged(object sender, System.EventArgs e)
        {
            UpdateTitle();
        }

        private void closeButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void addTaskActivityButton_Click(object sender, System.EventArgs e)
        {
            //string comments = commentsTextBox.Text,
            //       hours = hoursTextBox.Text;

            //if (projectName.Length > 0 && taskName.Length > 0
            //   && comments.Length > 0 && hours.Length > 0)
            //{
            //    double hoursWorked = 0;
            //    var conversionResult = double.TryParse(hours, out hoursWorked);
                
            //    if (conversionResult)
            //    {
            //        if(hoursWorked > 0 && hoursWorked < 10)
            //        {
            //            var taskModel = new TaskViewModel
            //            {
            //                ProjectName = projectName,
            //                TaskName = taskName,
            //                Hours = hoursWorked,
            //                Comments = comments
            //            };

            //        }
            //        else
            //            MessageBox.Show("The value in Hours field must be between 0 and 10");
            //    }
            //    else
            //        MessageBox.Show("Invalid value in Hours field");

            //}
            //else
            //    MessageBox.Show("All fields are required");

        }
    }
}
