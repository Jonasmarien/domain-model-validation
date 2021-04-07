using System.Collections.Generic;

namespace ValidationDemo.Domain.Models
{
    public class Team
    {
        public List<TeamMember> TeamMembers { get; set; } = new List<TeamMember>();
    }
}