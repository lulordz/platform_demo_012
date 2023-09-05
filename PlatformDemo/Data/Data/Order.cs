using System;
using System.Collections.Generic;

namespace Data.Data;

public partial class Order
{
    public int Id { get; set; }

    public int? OrderNumber { get; set; }

    public int? Amount { get; set; }

    public int? CustomerId { get; set; }

    public Customer Customer { get; set; }
}
