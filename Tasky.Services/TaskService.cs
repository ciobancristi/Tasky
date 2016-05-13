using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using Tasky.Entities;
using Tasky.Services.Common;
using Tasky.Services.Models;

namespace Tasky.Services
{
    public interface ITaskService
    {
        List<Task> GetTasks(DateTime date);
        void AddTask(NewTaskModel task);
        double GetWorkedHoursForWeek(Guid userId, DateTime startOfWeek);
    }
    public class TaskService : BaseService, ITaskService
    {
        private TaskyDBEntities _dbContext;
        private readonly IMapper _mapper;

        public TaskService()
        {
            _dbContext = new TaskyDBEntities();
            _mapper = App.Mapper;
        }

        #region ITaskService
        public void AddTask(NewTaskModel task)
        {
            if (task == null)
                throw new ArgumentNullException();
            var taskModel = _mapper.Map<Task>(task);
            //TODO: delete Name field from Task table
            taskModel.Name = " ";
            _dbContext.Tasks.Add(taskModel);
            _dbContext.SaveChanges();
        }

        public List<Task> GetTasks(DateTime date)
        {
            if (date == null)
                throw new ArgumentNullException();
            var startDate = date.Date;
            var endDate = date.Date.AddDays(1);
            var tasks = _dbContext.Tasks
                        .Where(x => (x.Date >= startDate && x.Date < endDate))
                        .ToList();
            return tasks;
        }

        public double GetWorkedHoursForWeek(Guid userId, DateTime startOfWeek)
        {
            if (userId == null || startOfWeek == null)
                throw new ArgumentNullException();

            var startDate = startOfWeek.Date;
            var endDate = startOfWeek.AddDays(6).Date;

            var hours = _dbContext.Tasks
                .Where(x => x.UserId == userId && x.Date >= startDate && x.Date <= endDate)
                .Select(x => x.Hours);

            double sum = 0;
            foreach(var value in hours)
            {
                sum += value;
            }

            return sum;
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
