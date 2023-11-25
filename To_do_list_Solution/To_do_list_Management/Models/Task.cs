namespace To_do_list_Management.Models
{
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int PriorityLevel { get; set; }
        public int CategoryId { get; set; }
    }
}
