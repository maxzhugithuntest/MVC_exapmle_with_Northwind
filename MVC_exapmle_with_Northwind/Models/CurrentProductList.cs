using System;
using System.Collections.Generic;

namespace MVC_exapmle_with_Northwind.Models;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
