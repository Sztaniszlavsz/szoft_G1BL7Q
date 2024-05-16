using System;
using System.Collections.Generic;

namespace zh3_MUF3SD.Models;

public partial class Type
{
    public byte TypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Cocktail> Cocktails { get; set; } = new List<Cocktail>();
}
