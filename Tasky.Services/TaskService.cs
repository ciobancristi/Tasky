using System.Collections.Generic;
using System.Linq;
using Tasky.Entities;

namespace Tasky.Services
{
    interface ITaskService
    {
    }
    public class TaskService : BaseService, ITaskService
    {
        private TaskyDBEntities _dbContext;
        public TaskService()
        {
            _dbContext = new TaskyDBEntities();
        }

        #region ITaskService
        
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
