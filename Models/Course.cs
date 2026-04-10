using System;
using System.Collections.Generic;

namespace DataBaseApproach.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public int AuthorId { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public short Price { get; set; }

    public string LevelString { get; set; } = null!;

    public byte Level { get; set; }
}
