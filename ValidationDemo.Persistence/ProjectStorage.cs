using System;
using System.Collections.Generic;
using System.Linq;
using ValidationDemo.Domain.Models;
using ValidationDemo.Domain.Ports;

namespace ValidationDemo.Persistence
{
    public class ProjectStorage : IProjectStorage
    {
        private readonly List<Project> _projects;

        public ProjectStorage()
        {
            _projects = new List<Project>();
        }

        public Project ReadById(Guid projectId)
        {
            return _projects.FirstOrDefault(p => p.Id.Equals(projectId));
        }
        
        public Project Save(Project project)
        {
            _projects.Add(project);
            return project;
        }

        public Project Update(Project project)
        {
            var projectToUpdate = _projects.First(p => p.Id.Equals(project.Id));
            projectToUpdate = project;
            return project;
        }
    }
}