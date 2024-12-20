using System;
using System.Collections.Generic;

namespace MVC_exapmle_with_Northwind.Models;

public partial class Many
{
    public int ManyId { get; set; }

    public int OneId { get; set; }

    public int? ManyData { get; set; }

    public virtual One One { get; set; } = null!;
}
