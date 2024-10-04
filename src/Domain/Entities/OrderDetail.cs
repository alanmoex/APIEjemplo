using System;

namespace Domain.Entities;

public class OrderDetail
{
    public Order Order{ get; set; }
    public Product Product{ get; set; }
    public int Quantity { get; set; }
    public float UnitPrice { get; set; }
}
