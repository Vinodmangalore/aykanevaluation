using System;
using System.Collections.Generic;

namespace Task.Data.Entities;

public partial class TblTask
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public DateTime? DueDate { get; set; }

    public string? PriorityLevel { get; set; }
}
