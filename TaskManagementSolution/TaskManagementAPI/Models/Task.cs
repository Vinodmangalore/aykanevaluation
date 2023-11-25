using System.Diagnostics.Metrics;

namespace TaskManagementAPI.Models

{
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set;}
        public string PriorityLevel { get; set; }

    }
}
