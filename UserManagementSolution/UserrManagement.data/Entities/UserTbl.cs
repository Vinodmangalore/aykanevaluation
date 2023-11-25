using System;
using System.Collections.Generic;

namespace UserrManagement.data.Entities
{
    public  class UserTbl
    {
        public UserTbl()
        {
            Tasks = new HashSet<Task>();
        }

        public int UserId { get; set; }
        public string? UserName { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
