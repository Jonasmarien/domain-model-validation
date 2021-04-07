using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ValidationDemo.Domain.Models
{
    public class Project
    {
        public Guid Id { get; }
        
        [Required]
        public Team Team { get; set; }
        
        public List<Timesheet> Timesheets { get; set; } = new List<Timesheet>();

        public Project()
        {
            Id = Guid.NewGuid();
        }
    }
}