﻿using System;
using System.Collections.Generic;

namespace MVC_exapmle_with_Northwind.Models;

public partial class ProductSalesFor1997
{
    public string CategoryName { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public decimal? ProductSales { get; set; }
}
