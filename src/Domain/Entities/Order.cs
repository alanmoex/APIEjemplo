using System;
using System.Reflection;

namespace Domain.Entities;

public class Order
{
    public int OrderId { get; set; }
    public Client Client { get; set; }
    public List<Product> Products{ get; set; }
    public float Total { get; set; }
}
