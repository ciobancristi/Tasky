﻿using AutoMapper;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Tasky.Services;
using Tasky.Services.Common;
using Tasky.Services.Helpers;
using Tasky.Services.Models;

namespace Tasky
{
    public partial class TimeCheckForm : Form
    {
        private ITaskService _taskService;
        private IProjectService _projectService;
        private readonly IMapper _mapper;

        public TimeCheckForm()
        {
            _taskService = new TaskService();
            _projectService = new ProjectService();
            _mapper = App.Mapper;

            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            BindTasks();
            UpdateTitle();
            BindProjects();
        }

        private void BindProjects()
        {
            var projects = _projectService
                            .GetActiveProjects(UserHelper.GetUserId())
                            .Select(x => _mapper.Map<NameValueItem>(x))
                            .ToList();
            projectComboBox.DataSource = projects;
            projectComboBox.DisplayMember = "Name";
            projectComboBox.ValueMember = "Value";
        }

        private void BindProjectTasks(int projectId)
        {
            if (projectId >= 0)
            {
                var projectTasks = _projectService
                                    .GetProjectTasks(projectId)
                                    .Select(x => _mapper.Map<NameValueItem>(x))
                                    .ToList();
                tasksComboBox.DataSource = projectTasks;
                tasksComboBox.DisplayMember = "Name";
                tasksComboBox.ValueMember = "Value";
            }
            else
            {
                MessageBox.Show("An error occurred with the selected project");
            }
        }

        private void UpdateTitle()
        {
            var displayedDate = dateTimePicker.Value.ToString("dddd, dd MMMM, yyyy");
            titleLabel.Text = "Add task activity for " + displayedDate;
        }

        private void BindTasks()
        {
            var date = dateTimePicker.Value.Date;
            var tasks = _taskService.GetTasks(date)
                        .Select(x => _mapper.Map<TaskViewModel>(x))
                        .ToList();
            if (tasks.Count > 0)
            {
                activitiesDataGridView.DataSource = tasks;
                activitiesDataGridView.Columns[0].Visible = false;
                activitiesDataGridView.Visible = true;
                noActivityLabel.Visible = false;
            }
            else
            {
                activitiesDataGridView.Visible = false;
                noActivityLabel.Visible = true;
            }
        }

        private void dateTimePicker_ValueChanged(object sender, System.EventArgs e)
        {
            UpdateTitle();
            BindTasks();
        }

        private void closeButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void addTaskActivityButton_Click(object sender, System.EventArgs e)
        {
            string comments = commentsTextBox.Text,
                   hours = hoursTextBox.Text;
            NameValueItem project = (NameValueItem)projectComboBox.SelectedItem,
                          projectTask = (NameValueItem)tasksComboBox.SelectedItem;
            DateTime selectedDate = dateTimePicker.Value.Date;

            if (comments.Length > 0 && hours.Length > 0)
            {
                double hoursWorked = 0;
                var conversionResult = double.TryParse(hours, out hoursWorked);

                if (conversionResult)
                {
                    if (hoursWorked > 0 && hoursWorked < 10)
                    {
                        var taskModel = new NewTaskModel
                        {
                            Description = comments,
                            Date = selectedDate,
                            Hours = hoursWorked,
                            ProjectId = int.Parse(project.Value),
                            ProjectTaskId = int.Parse(projectTask.Value),
                            UserId = UserHelper.GetUserId()
                        };
                        _taskService.AddTask(taskModel);
                        BindTasks();
                        commentsTextBox.Text = "";
                        hoursTextBox.Text = "";
                        MessageBox.Show("Task added successfully");
                    }
                    else
                    {
                        MessageBox.Show("The value in Hours field must be between 0 and 10");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid value in Hours field");
                }
            }
            else
            {
                MessageBox.Show("All fields are required");
            }
        }

        private void projectComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            NameValueItem selectedProject = (NameValueItem)projectComboBox.SelectedItem;
            BindProjectTasks(int.Parse(selectedProject.Value));
        }
    }
}