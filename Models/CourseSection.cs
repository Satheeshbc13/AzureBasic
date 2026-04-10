using System;
using System.Collections.Generic;

namespace DataBaseApproach.Models;

public partial class CourseSection
{
    public int SectionId { get; set; }

    public int CourseId { get; set; }

    public string Title { get; set; } = null!;
}
