using System;
using System.Collections.Generic;

namespace Data.Data;

public partial class Customer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? PhoneNumber { get; set; }

    public List<Order> Orders { get; set; }
}
