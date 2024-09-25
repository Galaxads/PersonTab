using System;
using System.Collections.Generic;

namespace Works.Models;

public partial class Gender
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Клиенты> Клиентыs { get; set; } = new List<Клиенты>();
}
