using System;
using System.Collections.Generic;

namespace TaskManagement.data.Entities;

public partial class TaskTable
{
    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? DueDate { get; set; }

    public string? PriorityLevel { get; set; }
}
