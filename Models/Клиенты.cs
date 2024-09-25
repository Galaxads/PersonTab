using System;
using System.Collections.Generic;

namespace Works.Models;

public partial class Клиенты
{
    public int Id { get; set; }

    public int Gender { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public DateOnly Birthday { get; set; }

    public string NumberPhone { get; set; } = null!;

    public string EmailAdress { get; set; } = null!;

    public DateOnly DateRegistr { get; set; }

    public int? Visit { get; set; }

    public int? ColvoVisit { get; set; }

    public int? Tag { get; set; }

    public string? Photo { get; set; }

    public int? Files { get; set; }

    public virtual FileList? FilesNavigation { get; set; }

    public virtual Gender GenderNavigation { get; set; } = null!;

    public virtual ICollection<Posehenium> Posehenia { get; set; } = new List<Posehenium>();

    public virtual ListTag? TagNavigation { get; set; }

    public virtual Posehenium? VisitNavigation { get; set; }
}
