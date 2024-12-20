using System;
using System.Collections.Generic;

namespace MVC_exapmle_with_Northwind.Models;

public partial class One
{
    public int OneId { get; set; }

    public int? OneData { get; set; }

    public virtual ICollection<Many> Manies { get; set; } = new List<Many>();
}
