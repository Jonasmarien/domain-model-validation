namespace ValidationDemo.Domain.Models
{
    public class Timesheet
    {
        public TeamMember TeamMember { get; set; }
        public int WeekNr { get; set; }
        public int Hours { get; set; }
    }
}