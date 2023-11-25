using System;
using System.Collections.Generic;

namespace To_do_list.Data.TaskEntities
{
    public partial class Categorytbl
    {
        public Categorytbl()
        {
            Tasktbls = new HashSet<Tasktbl>();
        }

        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Tasktbl> Tasktbls { get; set; }
    }
}
