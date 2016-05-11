using System;
using System.Collections.Generic;
using System.Linq;
using Tasky.Entities;

namespace Tasky.Services
{
    public interface ITaskService
    {
        List<Task> GetTasks(DateTime date);
        void AddTask(Task task);
    }
    public class TaskService : BaseService, ITaskService
    {
        private TaskyDBEntities _dbContext;
        public TaskService()
        {
            _dbContext = new TaskyDBEntities();
        }

        #region ITaskService
        public void AddTask(Task task)
        {
            if (task == null)
                throw new ArgumentNullException();
            _dbContext.Tasks.Add(task);
            _dbContext.SaveChanges();
        }

        public List<Task> GetTasks(DateTime date)
        {
            if (date == null)
                throw new ArgumentNullException();

            //var tasks = _dbContext.Tasks.Where(x => x.Date.Date == date.Date).ToList();
            //return tasks;
            return null;
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
