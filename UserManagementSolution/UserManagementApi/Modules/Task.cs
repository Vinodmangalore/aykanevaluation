namespace UserrManagementApi.Modules
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Description { get; set; }
        public DateOnly DueDate { get; set; }
        public int PriorityLevel { get; set; }
        public Category Category { get; set; }
    }
}
