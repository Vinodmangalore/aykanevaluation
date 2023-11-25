using System;
using System.Collections.Generic;

namespace To_do_list.Data.TaskEntities
{
    public partial class Tasktbl
    {
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public int? PriorityLevel { get; set; }
        public int? CategoryId { get; set; }

        public virtual Categorytbl? Category { get; set; }
    }
}
