using System;
using System.Collections.Generic;

namespace ToDo.Data.Entities;

public partial class Task
{
    public string? Category { get; set; }

    public string? Title { get; set; }

    public string? TaskDescription { get; set; }

    public DateTime? DueDate { get; set; }

    public int? PriorityLevel { get; set; }
}
