using System;
using System.Collections.Generic;

namespace UserrManagement.data.Entities
{
    public  class Task
    {
        public int TaskId { get; set; }
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public int? PriorityLevel { get; set; }
        public int? CategoryId { get; set; }
        public int? UserId { get; set; }

        public virtual Category? Category { get; set; }
        public virtual UserTbl? User { get; set; }
    }
}
