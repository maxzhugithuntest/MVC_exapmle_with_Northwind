using System;
using System.Collections.Generic;

namespace MVC_exapmle_with_Northwind.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
