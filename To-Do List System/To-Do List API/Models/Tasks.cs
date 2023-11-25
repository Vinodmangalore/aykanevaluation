namespace To_Do_List_API.Models
{
    public class Tasks
    {
        public string Category { get; set; }
      

        public string Title { get; set; }

        public string Description { get; set; }

        public DateOnly DueDate { get; set; }

        public int PriorityLevel { get; set; }


    }
}
