using System;
using System.Collections.Generic;

namespace Works.Models;

public partial class ListTag
{
    public int Id { get; set; }

    public int? IdTag { get; set; }

    public int? IdClient { get; set; }

    public virtual Tag? IdTagNavigation { get; set; }

    public virtual Клиенты? Клиенты { get; set; }
}
