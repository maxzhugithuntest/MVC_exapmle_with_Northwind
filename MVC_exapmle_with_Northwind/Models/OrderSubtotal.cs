using System;
using System.Collections.Generic;

namespace MVC_exapmle_with_Northwind.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
