using System;
using System.Collections.Generic;
using System.Linq;
using Tasky.Entities;
using Tasky.Services.Models;

namespace Tasky.Services
{
    public interface IProjectService
    {
        void AddProject(NewProjectModel newProject);
        List<Project> GetActiveProjects(Guid userId);
        List<ProjectTask> GetProjectTasks(int projectId);
        List<ProjectTask> GetProjectTasks();
        void EditProject(int projectId, EditProjectModel editedProject);
        int GetNumberOfActiveProjects();
        int GetNumberOfProjects();
        Project GetProject(int projectId);
        List<Project> GetProjects();
    }
    public class ProjectService : BaseService, IProjectService
    {
        private TaskyDBEntities _dbContext;

        public ProjectService()
        {
            _dbContext = new TaskyDBEntities();
        }

        #region IProjectService
        public void AddProject(NewProjectModel newProject)
        {
            var users = GetUsersByIds(newProject.UserIds);
            var projectTasks = GetProjectTasksByIds(newProject.TaskIds);
            var project = new Project
            {
                Name = newProject.Name,
                HasFinished = false,
                Created = DateTime.Now,
                ProjectTasks = projectTasks,
                Users = users,
                ClientId = newProject.ClientId
            };
            _dbContext.Projects.Add(project);
            _dbContext.SaveChanges();
        }

        public List<Project> GetProjects()
        {
            return _dbContext.Projects.ToList();
        }

        public List<Project> GetActiveProjects(Guid userId)
        {
            if (userId == null)
                throw new ArgumentNullException();

            var projects = _dbContext.Projects
                            .Where(p => p.Users.Any(u => u.UserId == userId) && p.HasFinished == false)
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

        public List<ProjectTask> GetProjectTasks()
        {
            var projectTasks = _dbContext.ProjectTasks.ToList();

            return projectTasks;
        }

        public void EditProject(int projectId, EditProjectModel editedProject)
        {
            var project = _dbContext.Projects.FirstOrDefault(x => x.ProjectId == projectId);
            var users = GetUsersByIds(editedProject.UserIds);
            var projectTasks = GetProjectTasksByIds(editedProject.TaskIds);
            var projectToEdit = new Project
            {
                Name = editedProject.Name,
                HasFinished = editedProject.HasFinished,
                ProjectTasks = projectTasks,
                Users = users,
                ClientId = editedProject.ClientId
            };

            project.Name = projectToEdit.Name;
            project.HasFinished = projectToEdit.HasFinished;
            project.ProjectTasks = projectToEdit.ProjectTasks;
            project.Users = projectToEdit.Users;
            project.ClientId = projectToEdit.ClientId;

            _dbContext.SaveChanges();
        }

        public int GetNumberOfActiveProjects()
        {
            return _dbContext.Projects.Where(x => x.HasFinished == false).Count();
        }

        public int GetNumberOfProjects()
        {
            return _dbContext.Projects.Count();
        }

        public Project GetProject(int projectId)
        {
            return _dbContext.Projects.FirstOrDefault(p => p.ProjectId == projectId);
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
