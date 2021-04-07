using System;

namespace ValidationDemo.Domain.Models
{
    public class TeamMember : Person
    {
        public TeamRole Role { get; set; }
    }

    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    public enum TeamRole
    {
        Architect,
        Developer,
        TeamLead,
        FunctionalAnalyst
    }
}