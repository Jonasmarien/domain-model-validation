using System;
using System.Linq;
using FluentValidation;
using ValidationDemo.Domain.Models;
using ValidationDemo.Domain.Ports;

namespace ValidationDemo.Domain.Services
{
    public interface IProjectDomainService
    {
        Project CreateProject(Project project);
        void AddTimesheet(Guid projectId);
    }
    
    public class ProjectDomainService : IProjectDomainService
    {
        private readonly IValidator<Project> _validator;
        private readonly IProjectStorage _projectStorage;

        public ProjectDomainService(IValidator<Project> validator, IProjectStorage projectStorage)
        {
            _validator = validator;
            _projectStorage = projectStorage;
        }
        
        public Project CreateProject(Project project)
        {
            var validationResult = _validator.Validate(project);

            if (!validationResult.IsValid)
            {
                var message = string.Join(",", validationResult.Errors.Select(e => e.ErrorMessage));
                throw new ValidationException(message);
            }

            return _projectStorage.Save(project);
        }

        public void AddTimesheet(Guid projectId)
        {
            throw new NotImplementedException();
        }
    }
}