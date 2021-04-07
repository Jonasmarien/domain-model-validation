using System;
using System.Linq;
using FluentValidation;
using ValidationDemo.Domain.Models;

namespace ValidationDemo.Domain.Validation
{
    public class ProjectValidator : AbstractValidator<Project>
    {
        public ProjectValidator()
        {
            RuleFor(project => project.Team.TeamMembers)
                .NotEmpty()
                .WithMessage("At least 1 team member is required");

            RuleFor(project => project.Team.TeamMembers)
                .Must(members => members.Any(m => m.Role == TeamRole.TeamLead))
                .WithMessage("The team needs a team lead.");

            RuleFor(project => project.Team.TeamMembers)
                .Must(members => members.Count(m => m.Role == TeamRole.TeamLead) > 1)
                .WithMessage("The team only needs 1 team lead.");
        }
    }
}