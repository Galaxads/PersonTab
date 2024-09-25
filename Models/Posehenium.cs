using System;
using System.Collections.Generic;

namespace Works.Models;

public partial class Posehenium
{
    public int Id { get; set; }

    public int? IdKlient { get; set; }

    public int? IdPosh { get; set; }

    public virtual Клиенты? IdKlientNavigation { get; set; }

    public virtual Visit? IdPoshNavigation { get; set; }

    public virtual Клиенты? Клиенты { get; set; }
}
