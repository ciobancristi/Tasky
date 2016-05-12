using System;
using System.Collections.Generic;
using System.Linq;
using Tasky.Entities;

namespace Tasky.Services
{
    public interface IProjectService
    {
        void AddProject(string name, string client, List<Guid> userIds, List<int> taskIds);
        List<Project> GetActiveProjects(Guid userId);
        List<ProjectTask> GetProjectTasks(int projectId);
    }
    public class ProjectService : BaseService, IProjectService
    {
        private TaskyDBEntities _dbContext;

        public ProjectService()
        {
            _dbContext = new TaskyDBEntities();
        }

        #region IProjectService
        public void AddProject(string name, string client, List<Guid> userIds, List<int> taskIds)
        {
            var users = GetUsersByIds(userIds);
            //var projectTasks = GetProjectTasksByIds(taskIds);
            //var project = new Project
            //{
            //    Name = name,
            //    Client = client,
            //    HasFinished = false,
            //    Created = DateTime.Now,
            //    ProjectTasks = projectTasks,
            //    Users = users,
            //};
            //_dbContext.Projects.Add(project);
            //_dbContext.SaveChanges();
        }

        public List<Project> GetActiveProjects(Guid userId)
        {
            if (userId == null)
                throw new ArgumentNullException();

            var projects = _dbContext.Projects
                            .Where(p => (p.Users.FirstOrDefault(u => u.UserId == userId) != null)
                                        && p.HasFinished == false)
                            .ToList();

            return projects;
        }

        public List<ProjectTask> GetProjectTasks(int projectId)
        {
            if (projectId < 0)
                throw new ArgumentOutOfRangeException();

            var projectTasks = _dbContext.ProjectTasks
                                .Where(p => p.Projects.FirstOrDefault(x => x.ProjectId == projectId) != null)
                                .ToList();

            return projectTasks;
        }
        #endregion

        #region private members
        public List<User> GetUsersByIds(List<Guid> userIds)
        {
            var users = new List<User>();
            foreach (var id in userIds)
            {
                var user =
                    _dbContext.Users.FirstOrDefault(u => u.UserId == id);
                if (user != null)
                    users.Add(user);
            }
            return users;
        }

        public List<ProjectTask> GetProjectTasksByIds(List<int> taskIds)
        {
            var projectTasks = new List<ProjectTask>();
            foreach (var id in taskIds)
            {
                var projectTask =
                    _dbContext.ProjectTasks.FirstOrDefault(t => t.ProjectTaskId == id);
                if (projectTask != null)
                    projectTasks.Add(projectTask);
            }
            return projectTasks;
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
