using System;
using System.Collections.Generic;

namespace UserrManagement.data.Entities
{
    public  class Category
    {
        public Category()
        {
            Tasks = new HashSet<Task>();
        }

        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryDescription { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
