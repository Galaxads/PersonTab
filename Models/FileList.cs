using System;
using System.Collections.Generic;

namespace Works.Models;

public partial class FileList
{
    public int Id { get; set; }

    public int IdFile { get; set; }

    public string? Filessilka { get; set; }

    public virtual Клиенты? Клиенты { get; set; }
}
