using System;
using System.Collections.Generic;

namespace Works.Models;

public partial class Visit
{
    public int Id { get; set; }

    public DateOnly DateVisit { get; set; }

    public TimeOnly TimeVisit { get; set; }

    public int? ColvoVisit { get; set; }

    public virtual ICollection<Posehenium> Posehenia { get; set; } = new List<Posehenium>();
}
