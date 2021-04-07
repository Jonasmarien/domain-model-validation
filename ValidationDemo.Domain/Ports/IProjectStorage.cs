using System;
using ValidationDemo.Domain.Models;

namespace ValidationDemo.Domain.Ports
{
    public interface IProjectStorage
    {
        Project ReadById(Guid projectId);
        Project Save(Project project);
        Project Update(Project project);
    }
}